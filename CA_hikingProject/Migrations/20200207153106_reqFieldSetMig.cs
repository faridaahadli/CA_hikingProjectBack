using Microsoft.EntityFrameworkCore.Migrations;

namespace CA_hikingProject.Migrations
{
    public partial class reqFieldSetMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_AspNetUsers_WriterId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blog_BlogId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvt_AspNetUsers_GuideId",
                table: "GuideToTourPvt");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvt_SingleTour_TourId",
                table: "GuideToTourPvt");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImage_Image_ImageId",
                table: "OneTourImage");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImage_SingleTour_SingleTourId",
                table: "OneTourImage");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProduct_PartnerCompany_PartnerId",
                table: "PartnerWithProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProduct_SingleTour_SingleTourId",
                table: "PartnerWithProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_SingleTour_SingleTourId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Comment_CommentId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_AspNetUsers_UserId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirement_SingleTour_SingleTourId",
                table: "Requirement");

            migrationBuilder.DropForeignKey(
                name: "FK_SingleTour_TourType_TourTypeId",
                table: "SingleTour");

            migrationBuilder.DropForeignKey(
                name: "FK_TagOfArticle_Blog_BlogId",
                table: "TagOfArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_TagOfArticle_Tag_TagId",
                table: "TagOfArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuide_AspNetUsers_GuideId",
                table: "TypeOfGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuide_TourType_TourTypeId",
                table: "TypeOfGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfo_SingleTour_TourId",
                table: "UserCustomPayingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfo_AspNetUsers_UserId",
                table: "UserCustomPayingInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_AspNetUsers_WriterId",
                table: "Blog",
                column: "WriterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Blog_BlogId",
                table: "Comment",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvt_AspNetUsers_GuideId",
                table: "GuideToTourPvt",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvt_SingleTour_TourId",
                table: "GuideToTourPvt",
                column: "TourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImage_Image_ImageId",
                table: "OneTourImage",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImage_SingleTour_SingleTourId",
                table: "OneTourImage",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProduct_PartnerCompany_PartnerId",
                table: "PartnerWithProduct",
                column: "PartnerId",
                principalTable: "PartnerCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProduct_SingleTour_SingleTourId",
                table: "PartnerWithProduct",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_SingleTour_SingleTourId",
                table: "Rate",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Comment_CommentId",
                table: "Reply",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_AspNetUsers_UserId",
                table: "Reply",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirement_SingleTour_SingleTourId",
                table: "Requirement",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SingleTour_TourType_TourTypeId",
                table: "SingleTour",
                column: "TourTypeId",
                principalTable: "TourType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagOfArticle_Blog_BlogId",
                table: "TagOfArticle",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagOfArticle_Tag_TagId",
                table: "TagOfArticle",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuide_AspNetUsers_GuideId",
                table: "TypeOfGuide",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuide_TourType_TourTypeId",
                table: "TypeOfGuide",
                column: "TourTypeId",
                principalTable: "TourType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfo_SingleTour_TourId",
                table: "UserCustomPayingInfo",
                column: "TourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfo_AspNetUsers_UserId",
                table: "UserCustomPayingInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_AspNetUsers_WriterId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blog_BlogId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvt_AspNetUsers_GuideId",
                table: "GuideToTourPvt");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvt_SingleTour_TourId",
                table: "GuideToTourPvt");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImage_Image_ImageId",
                table: "OneTourImage");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImage_SingleTour_SingleTourId",
                table: "OneTourImage");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProduct_PartnerCompany_PartnerId",
                table: "PartnerWithProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProduct_SingleTour_SingleTourId",
                table: "PartnerWithProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_SingleTour_SingleTourId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Comment_CommentId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_AspNetUsers_UserId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirement_SingleTour_SingleTourId",
                table: "Requirement");

            migrationBuilder.DropForeignKey(
                name: "FK_SingleTour_TourType_TourTypeId",
                table: "SingleTour");

            migrationBuilder.DropForeignKey(
                name: "FK_TagOfArticle_Blog_BlogId",
                table: "TagOfArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_TagOfArticle_Tag_TagId",
                table: "TagOfArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuide_AspNetUsers_GuideId",
                table: "TypeOfGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuide_TourType_TourTypeId",
                table: "TypeOfGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfo_SingleTour_TourId",
                table: "UserCustomPayingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfo_AspNetUsers_UserId",
                table: "UserCustomPayingInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_AspNetUsers_WriterId",
                table: "Blog",
                column: "WriterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Blog_BlogId",
                table: "Comment",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvt_AspNetUsers_GuideId",
                table: "GuideToTourPvt",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvt_SingleTour_TourId",
                table: "GuideToTourPvt",
                column: "TourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImage_Image_ImageId",
                table: "OneTourImage",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImage_SingleTour_SingleTourId",
                table: "OneTourImage",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProduct_PartnerCompany_PartnerId",
                table: "PartnerWithProduct",
                column: "PartnerId",
                principalTable: "PartnerCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProduct_SingleTour_SingleTourId",
                table: "PartnerWithProduct",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_SingleTour_SingleTourId",
                table: "Rate",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Comment_CommentId",
                table: "Reply",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_AspNetUsers_UserId",
                table: "Reply",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirement_SingleTour_SingleTourId",
                table: "Requirement",
                column: "SingleTourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SingleTour_TourType_TourTypeId",
                table: "SingleTour",
                column: "TourTypeId",
                principalTable: "TourType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagOfArticle_Blog_BlogId",
                table: "TagOfArticle",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagOfArticle_Tag_TagId",
                table: "TagOfArticle",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuide_AspNetUsers_GuideId",
                table: "TypeOfGuide",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuide_TourType_TourTypeId",
                table: "TypeOfGuide",
                column: "TourTypeId",
                principalTable: "TourType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfo_SingleTour_TourId",
                table: "UserCustomPayingInfo",
                column: "TourId",
                principalTable: "SingleTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfo_AspNetUsers_UserId",
                table: "UserCustomPayingInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
