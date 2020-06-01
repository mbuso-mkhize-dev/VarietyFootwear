using Microsoft.EntityFrameworkCore.Migrations;

namespace VarietyFootwear.EntityFramework.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    MailingListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    Like_ = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Feedback = table.Column<string>(unicode: false, maxLength: 26, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Feedback__4CE9ED5B2425E0B3", x => x.MailingListID);
                });

            migrationBuilder.CreateTable(
                name: "Kids",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    ProductSize = table.Column<long>(nullable: true),
                    UnitPrice = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Colour = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Section = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Image = table.Column<string>(unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kids__B40CC6ED6CE9AFAE", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Mens",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    ProductSize = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Colour = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Section = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Image = table.Column<string>(unicode: false, maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mens__B40CC6ED15719022", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    PurchaseOrderNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<long>(nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    EmailName = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    ProductName = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    Size = table.Column<int>(nullable: true),
                    Price = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Section = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Colour = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__96241949FC663C92", x => x.PurchaseOrderNumber);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    UserID = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    Postcode = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    EmailAdress = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Password_ = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    CreditCardNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Register__1788CCAC13B3BA02", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    ProductSize = table.Column<long>(nullable: true),
                    UnitPrice = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Colour = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Section = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Image = table.Column<string>(unicode: false, maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Shoes__B40CC6ED3E5E8C10", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Kids");

            migrationBuilder.DropTable(
                name: "Mens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "Shoes");
        }
    }
}
