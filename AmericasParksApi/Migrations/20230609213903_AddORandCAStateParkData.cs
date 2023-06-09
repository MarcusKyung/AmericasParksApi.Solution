using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmericasParksApi.Migrations
{
    public partial class AddORandCAStateParkData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "DateEstablished", "Description", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 64, "330 acres", "1954", "Tumalo State Park is a well-developed state park in Deschutes County, Oregon, United States. Established in 1954, the park is located northwest of the city of Bend and along the Deschutes River at a site home to many bird species. The park is popular for picnics, swimming, fishing, hiking, and camping, and is open year-round.", "Oregon", "Tumalo", "State Park" },
                    { 65, "9000 acres", "1933", "Silver Falls State Park is a state park in the U.S. state of Oregon, located near Silverton, about 20 miles (32 km) east-southeast of Salem. It is the largest state park in Oregon with an area of more than 9,000 acres (36 km2), and it includes more than 24 miles (39 km) of walking trails, 14 miles (23 km) of horse trails, and a 4-mile (6.4 km) bike path.", "Oregon", "Silver Falls", "State Park" },
                    { 66, "147,242.66 acres", "1919", "South Beach State Park is a state park in the U.S. state of Oregon, administered by the Oregon Parks and Recreation Department. It is near the unincorporated community of South Beach.", "Oregon", "South Beach", "State Park" },
                    { 67, "2,256 acres", "1931", "Protects part of the largest lagoon system in the United States, including Big Lagoon, Stone Lagoon, and Freshwater Lagoon.", "California", "Humboldt Lagoons", "State Park" },
                    { 68, "2,309 acres", "1932", "Preserves rocky coast and rare habitats like mima mounds and Monterey pine forest, as well as a 5,850-year-old Native American archaeological site.", "California", "Hearst San Simeon", "State Park" },
                    { 69, "24,693 acres", "1933", "Preserves an expansive tract of forests and meadows above 5,000 feet (1,500 m) in the Laguna Mountains, on the former Rancho Cuyamaca.", "California", "Cuyamaca Rancho", "State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69);
        }
    }
}
