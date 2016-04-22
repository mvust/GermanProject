using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;

namespace GermanProject.Migrations
{
    public partial class newmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("FK_VocabWord_Chapter_ChapterId", "VocabWord");
            migrationBuilder.DropForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles");
            migrationBuilder.CreateTable("Result", table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                ChapterId = table.Column<int>(nullable: false),
                Correct = table.Column<int>(nullable: false),
                User = table.Column<string>(nullable: true),
                Wrong = table.Column<int>(nullable: false)
            },
                constraints: table => { table.PrimaryKey("PK_Result", x => x.Id); });
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
            migrationBuilder.DropForeignKey("FK_IdentityRoleClaim<string>_IdentityRole_RoleId", "AspNetRoleClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserClaim<string>_ApplicationUser_UserId", "AspNetUserClaims");
            migrationBuilder.DropForeignKey("FK_IdentityUserLogin<string>_ApplicationUser_UserId", "AspNetUserLogins");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_IdentityRole_RoleId", "AspNetUserRoles");
            migrationBuilder.DropForeignKey("FK_IdentityUserRole<string>_ApplicationUser_UserId", "AspNetUserRoles");
            migrationBuilder.DropTable("Result");
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