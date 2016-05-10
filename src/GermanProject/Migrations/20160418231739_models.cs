using Microsoft.Data.Entity.Migrations;

namespace GermanProject.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("FK_VocabWord_Chapter_ChapterId", "VocabWord");
            migrationBuilder.DropForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles");
            migrationBuilder.AlterColumn<int>("ChapterId", "VocabWord",
                nullable: false);
            migrationBuilder.AddColumn<int>("ChapterPart", "VocabWord",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey("FK_VocabWord_Chapter_ChapterId", "VocabWord", "ChapterId", "Chapter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims",
                "RoleId", "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles",
                "RoleId", "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("FK_VocabWord_Chapter_ChapterId", "VocabWord");
            migrationBuilder.DropForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles");
            migrationBuilder.DropColumn("ChapterPart", "VocabWord");
            migrationBuilder.AlterColumn<int>("ChapterId", "VocabWord",
                nullable: true);
            migrationBuilder.AddForeignKey("FK_VocabWord_Chapter_ChapterId", "VocabWord", "ChapterId", "Chapter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims",
                "RoleId", "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles",
                "RoleId", "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles",
                "UserId", "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}