using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityPazorPge.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoleAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Roles",
               columns: [ "Id", "Name", "NormalizedName", "ConcurrencyStamp" ],
               values:  [Guid.NewGuid().ToString(), "User", "User".ToUpper(), Guid.NewGuid().ToString() ],
               schema: "Security"
               );
            migrationBuilder.InsertData(
             table: "Roles",
             columns: [ "Id", "Name", "NormalizedName", "ConcurrencyStamp" ],
             values:  [ Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() ],
             schema: "Security"
             );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from [Secuirty].[Roles]");
        }
    }
}
