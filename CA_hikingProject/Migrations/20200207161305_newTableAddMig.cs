using Microsoft.EntityFrameworkCore.Migrations;

namespace CA_hikingProject.Migrations
{
    public partial class newTableAddMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_AspNetUsers_WriterId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blog_BlogId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
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
                name: "FK_PartnerWithProduct_AspNetUsers_UserId",
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
                name: "FK_Tag_AspNetUsers_TagCreatorId",
                table: "Tag");

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

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCustomPayingInfo",
                table: "UserCustomPayingInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfGuide",
                table: "TypeOfGuide");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourType",
                table: "TourType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagOfArticle",
                table: "TagOfArticle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SingleTour",
                table: "SingleTour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requirement",
                table: "Requirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reply",
                table: "Reply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rate",
                table: "Rate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerWithProduct",
                table: "PartnerWithProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerCompany",
                table: "PartnerCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OneTourImage",
                table: "OneTourImage");

            migrationBuilder.DropIndex(
                name: "IX_OneTourImage_ImageId",
                table: "OneTourImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GuideToTourPvt",
                table: "GuideToTourPvt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.RenameTable(
                name: "UserCustomPayingInfo",
                newName: "UserCustomPayingInfos");

            migrationBuilder.RenameTable(
                name: "TypeOfGuide",
                newName: "TypeOfGuides");

            migrationBuilder.RenameTable(
                name: "TourType",
                newName: "TourTypes");

            migrationBuilder.RenameTable(
                name: "TagOfArticle",
                newName: "TagsOfArticles");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "SingleTour",
                newName: "SingleTours");

            migrationBuilder.RenameTable(
                name: "Requirement",
                newName: "Requirements");

            migrationBuilder.RenameTable(
                name: "Reply",
                newName: "Replies");

            migrationBuilder.RenameTable(
                name: "Rate",
                newName: "Rates");

            migrationBuilder.RenameTable(
                name: "PartnerWithProduct",
                newName: "PartnerWithProducts");

            migrationBuilder.RenameTable(
                name: "PartnerCompany",
                newName: "PartnerCompanies");

            migrationBuilder.RenameTable(
                name: "OneTourImage",
                newName: "OneTourImages");

            migrationBuilder.RenameTable(
                name: "GuideToTourPvt",
                newName: "GuideToTourPvts");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_UserCustomPayingInfo_UserId",
                table: "UserCustomPayingInfos",
                newName: "IX_UserCustomPayingInfos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCustomPayingInfo_TourId",
                table: "UserCustomPayingInfos",
                newName: "IX_UserCustomPayingInfos_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeOfGuide_TourTypeId",
                table: "TypeOfGuides",
                newName: "IX_TypeOfGuides_TourTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeOfGuide_GuideId",
                table: "TypeOfGuides",
                newName: "IX_TypeOfGuides_GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_TagOfArticle_TagId",
                table: "TagsOfArticles",
                newName: "IX_TagsOfArticles_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagOfArticle_BlogId",
                table: "TagsOfArticles",
                newName: "IX_TagsOfArticles_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_TagCreatorId",
                table: "Tags",
                newName: "IX_Tags_TagCreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_SingleTour_TourTypeId",
                table: "SingleTours",
                newName: "IX_SingleTours_TourTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Requirement_SingleTourId",
                table: "Requirements",
                newName: "IX_Requirements_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_Reply_UserId",
                table: "Replies",
                newName: "IX_Replies_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reply_CommentId",
                table: "Replies",
                newName: "IX_Replies_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Rate_UserId",
                table: "Rates",
                newName: "IX_Rates_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rate_SingleTourId",
                table: "Rates",
                newName: "IX_Rates_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProduct_UserId",
                table: "PartnerWithProducts",
                newName: "IX_PartnerWithProducts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProduct_SingleTourId",
                table: "PartnerWithProducts",
                newName: "IX_PartnerWithProducts_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProduct_PartnerId",
                table: "PartnerWithProducts",
                newName: "IX_PartnerWithProducts_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_OneTourImage_SingleTourId",
                table: "OneTourImages",
                newName: "IX_OneTourImages_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_GuideToTourPvt_TourId",
                table: "GuideToTourPvts",
                newName: "IX_GuideToTourPvts_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_GuideToTourPvt_GuideId",
                table: "GuideToTourPvts",
                newName: "IX_GuideToTourPvts_GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_BlogId",
                table: "Comments",
                newName: "IX_Comments_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_WriterId",
                table: "Blogs",
                newName: "IX_Blogs_WriterId");

            migrationBuilder.AddColumn<int>(
                name: "myImageId",
                table: "OneTourImages",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCustomPayingInfos",
                table: "UserCustomPayingInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfGuides",
                table: "TypeOfGuides",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourTypes",
                table: "TourTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagsOfArticles",
                table: "TagsOfArticles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SingleTours",
                table: "SingleTours",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requirements",
                table: "Requirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Replies",
                table: "Replies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerWithProducts",
                table: "PartnerWithProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerCompanies",
                table: "PartnerCompanies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OneTourImages",
                table: "OneTourImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuideToTourPvts",
                table: "GuideToTourPvts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavMenus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OneTourImages_myImageId",
                table: "OneTourImages",
                column: "myImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_WriterId",
                table: "Blogs",
                column: "WriterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvts_AspNetUsers_GuideId",
                table: "GuideToTourPvts",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GuideToTourPvts_SingleTours_TourId",
                table: "GuideToTourPvts",
                column: "TourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImages_SingleTours_SingleTourId",
                table: "OneTourImages",
                column: "SingleTourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImages_Images_myImageId",
                table: "OneTourImages",
                column: "myImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProducts_PartnerCompanies_PartnerId",
                table: "PartnerWithProducts",
                column: "PartnerId",
                principalTable: "PartnerCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProducts_SingleTours_SingleTourId",
                table: "PartnerWithProducts",
                column: "SingleTourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerWithProducts_AspNetUsers_UserId",
                table: "PartnerWithProducts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_SingleTours_SingleTourId",
                table: "Rates",
                column: "SingleTourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_AspNetUsers_UserId",
                table: "Rates",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_CommentId",
                table: "Replies",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_UserId",
                table: "Replies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirements_SingleTours_SingleTourId",
                table: "Requirements",
                column: "SingleTourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SingleTours_TourTypes_TourTypeId",
                table: "SingleTours",
                column: "TourTypeId",
                principalTable: "TourTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_TagCreatorId",
                table: "Tags",
                column: "TagCreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagsOfArticles_Blogs_BlogId",
                table: "TagsOfArticles",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagsOfArticles_Tags_TagId",
                table: "TagsOfArticles",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuides_AspNetUsers_GuideId",
                table: "TypeOfGuides",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfGuides_TourTypes_TourTypeId",
                table: "TypeOfGuides",
                column: "TourTypeId",
                principalTable: "TourTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfos_SingleTours_TourId",
                table: "UserCustomPayingInfos",
                column: "TourId",
                principalTable: "SingleTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCustomPayingInfos_AspNetUsers_UserId",
                table: "UserCustomPayingInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_WriterId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvts_AspNetUsers_GuideId",
                table: "GuideToTourPvts");

            migrationBuilder.DropForeignKey(
                name: "FK_GuideToTourPvts_SingleTours_TourId",
                table: "GuideToTourPvts");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImages_SingleTours_SingleTourId",
                table: "OneTourImages");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImages_Images_myImageId",
                table: "OneTourImages");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProducts_PartnerCompanies_PartnerId",
                table: "PartnerWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProducts_SingleTours_SingleTourId",
                table: "PartnerWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerWithProducts_AspNetUsers_UserId",
                table: "PartnerWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_SingleTours_SingleTourId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_AspNetUsers_UserId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_CommentId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_UserId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirements_SingleTours_SingleTourId",
                table: "Requirements");

            migrationBuilder.DropForeignKey(
                name: "FK_SingleTours_TourTypes_TourTypeId",
                table: "SingleTours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_TagCreatorId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_TagsOfArticles_Blogs_BlogId",
                table: "TagsOfArticles");

            migrationBuilder.DropForeignKey(
                name: "FK_TagsOfArticles_Tags_TagId",
                table: "TagsOfArticles");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuides_AspNetUsers_GuideId",
                table: "TypeOfGuides");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfGuides_TourTypes_TourTypeId",
                table: "TypeOfGuides");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfos_SingleTours_TourId",
                table: "UserCustomPayingInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCustomPayingInfos_AspNetUsers_UserId",
                table: "UserCustomPayingInfos");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "NavMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCustomPayingInfos",
                table: "UserCustomPayingInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfGuides",
                table: "TypeOfGuides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourTypes",
                table: "TourTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagsOfArticles",
                table: "TagsOfArticles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SingleTours",
                table: "SingleTours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requirements",
                table: "Requirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Replies",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerWithProducts",
                table: "PartnerWithProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerCompanies",
                table: "PartnerCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OneTourImages",
                table: "OneTourImages");

            migrationBuilder.DropIndex(
                name: "IX_OneTourImages_myImageId",
                table: "OneTourImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GuideToTourPvts",
                table: "GuideToTourPvts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "myImageId",
                table: "OneTourImages");

            migrationBuilder.RenameTable(
                name: "UserCustomPayingInfos",
                newName: "UserCustomPayingInfo");

            migrationBuilder.RenameTable(
                name: "TypeOfGuides",
                newName: "TypeOfGuide");

            migrationBuilder.RenameTable(
                name: "TourTypes",
                newName: "TourType");

            migrationBuilder.RenameTable(
                name: "TagsOfArticles",
                newName: "TagOfArticle");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "SingleTours",
                newName: "SingleTour");

            migrationBuilder.RenameTable(
                name: "Requirements",
                newName: "Requirement");

            migrationBuilder.RenameTable(
                name: "Replies",
                newName: "Reply");

            migrationBuilder.RenameTable(
                name: "Rates",
                newName: "Rate");

            migrationBuilder.RenameTable(
                name: "PartnerWithProducts",
                newName: "PartnerWithProduct");

            migrationBuilder.RenameTable(
                name: "PartnerCompanies",
                newName: "PartnerCompany");

            migrationBuilder.RenameTable(
                name: "OneTourImages",
                newName: "OneTourImage");

            migrationBuilder.RenameTable(
                name: "GuideToTourPvts",
                newName: "GuideToTourPvt");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameIndex(
                name: "IX_UserCustomPayingInfos_UserId",
                table: "UserCustomPayingInfo",
                newName: "IX_UserCustomPayingInfo_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCustomPayingInfos_TourId",
                table: "UserCustomPayingInfo",
                newName: "IX_UserCustomPayingInfo_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeOfGuides_TourTypeId",
                table: "TypeOfGuide",
                newName: "IX_TypeOfGuide_TourTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeOfGuides_GuideId",
                table: "TypeOfGuide",
                newName: "IX_TypeOfGuide_GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_TagsOfArticles_TagId",
                table: "TagOfArticle",
                newName: "IX_TagOfArticle_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagsOfArticles_BlogId",
                table: "TagOfArticle",
                newName: "IX_TagOfArticle_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_TagCreatorId",
                table: "Tag",
                newName: "IX_Tag_TagCreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_SingleTours_TourTypeId",
                table: "SingleTour",
                newName: "IX_SingleTour_TourTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Requirements_SingleTourId",
                table: "Requirement",
                newName: "IX_Requirement_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_UserId",
                table: "Reply",
                newName: "IX_Reply_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentId",
                table: "Reply",
                newName: "IX_Reply_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_UserId",
                table: "Rate",
                newName: "IX_Rate_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_SingleTourId",
                table: "Rate",
                newName: "IX_Rate_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProducts_UserId",
                table: "PartnerWithProduct",
                newName: "IX_PartnerWithProduct_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProducts_SingleTourId",
                table: "PartnerWithProduct",
                newName: "IX_PartnerWithProduct_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerWithProducts_PartnerId",
                table: "PartnerWithProduct",
                newName: "IX_PartnerWithProduct_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_OneTourImages_SingleTourId",
                table: "OneTourImage",
                newName: "IX_OneTourImage_SingleTourId");

            migrationBuilder.RenameIndex(
                name: "IX_GuideToTourPvts_TourId",
                table: "GuideToTourPvt",
                newName: "IX_GuideToTourPvt_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_GuideToTourPvts_GuideId",
                table: "GuideToTourPvt",
                newName: "IX_GuideToTourPvt_GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogId",
                table: "Comment",
                newName: "IX_Comment_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_WriterId",
                table: "Blog",
                newName: "IX_Blog_WriterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCustomPayingInfo",
                table: "UserCustomPayingInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfGuide",
                table: "TypeOfGuide",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourType",
                table: "TourType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagOfArticle",
                table: "TagOfArticle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SingleTour",
                table: "SingleTour",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requirement",
                table: "Requirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reply",
                table: "Reply",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rate",
                table: "Rate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerWithProduct",
                table: "PartnerWithProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerCompany",
                table: "PartnerCompany",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OneTourImage",
                table: "OneTourImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuideToTourPvt",
                table: "GuideToTourPvt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OneTourImage_ImageId",
                table: "OneTourImage",
                column: "ImageId");

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
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
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
                name: "FK_PartnerWithProduct_AspNetUsers_UserId",
                table: "PartnerWithProduct",
                column: "UserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Tag_AspNetUsers_TagCreatorId",
                table: "Tag",
                column: "TagCreatorId",
                principalTable: "AspNetUsers",
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
    }
}
