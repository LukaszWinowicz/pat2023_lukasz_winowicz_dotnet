using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace pat2023lukaszwinowiczdotnet.Migrations
{
    /// <inheritdoc />
    public partial class addedauthorsandbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 3, new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K.", true, "Rowling" },
                    { 4, new DateTime(1889, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ernest", false, "Hemingway" },
                    { 5, new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", true, "Austen" },
                    { 6, new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", false, "King" },
                    { 7, new DateTime(1943, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elena", true, "Ferrante" },
                    { 8, new DateTime(1942, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", false, "Irving" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PublicationDate", "Rating" },
                values: new object[] { "This is the first novel in which Murakami takes up the risky topic of fringe religious groups—a sore spot in Japan since the Aum Shinrikyō terrorist attack of 1995.", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PublicationDate", "Rating" },
                values: new object[] { "Bilbo Baggins, the protagonist, is a respectable, reserved hobbit—a race resembling short humans with furry, leathery feet who live in underground houses and are mainly pastoral farmers and gardeners.", new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.8m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ISBN", "PublicationDate", "Rating", "Title" },
                values: new object[,]
                {
                    { 4, "Surely the most confusing of all Murakami novels, this one has three protagonists, each from a different generation.", "XXX126", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5m, "Kafka on the Shore" },
                    { 5, "The Lord of the Rings is an epic[1] high-fantasy novel[a] by English author and scholar J. R. R. Tolkien. Set in Middle-earth, intended to be Earth at some time in the distant past, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.", "XXX127", new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.2m, "The Lord of the Rings" },
                    { 6, "Harry Potter lives with his abusive aunt and uncle, Vernon and Petunia Dursley and their bullying son, Dudley. On Harry's eleventh birthday, a half-giant named Rubeus Hagrid personally delivers an acceptance letter to Hogwarts School of Witchcraft and Wizardry, revealing that Harry's parents, James and Lily Potter, were wizards. When Harry was one year old, an evil and powerful dark wizard, Lord Voldemort, murdered his parents. Harry survived Voldemort's killing curse that rebounded off his forehead and seemingly destroyed the Dark Lord, leaving a lightning bolt-shaped scar on his forehead. Unknown to Harry, he is famous in the wizarding world", "XXX128", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.8m, "Harry Potter and the Philosopher's Stone" },
                    { 7, "While spending the summer at the Dursleys, twelve-year-old Harry Potter is visited by a house-elf named Dobby. He warns that Harry is in danger and must not return to Hogwarts. Harry refuses, so Dobby magically ruins Aunt Petunia and Uncle Vernon's dinner party.", "XXX129", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.6m, "Harry Potter and the Chamber of Secrets" },
                    { 8, "On the surface, the novel is a love story between the protagonist Jake Barnes—a man whose war wound has made him unable to have sex—and the promiscuous divorcée Lady Brett Ashley.", "XXX130", new DateTime(1926, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.3m, "The Sun Also Rises" },
                    { 9, "Robert Jordan is an American, formerly a professor of Spanish language at the University of Montana. He had lived in prewar Spain, and fights as an irregular soldier for the Republic against Francisco Franco's fascist forces. ", "XXX131", new DateTime(1940, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.4m, "For Whom the Bell Tolls" },
                    { 10, "In the early 19th century, the Bennet family live at their Longbourn estate, situated near the village of Meryton in Hertfordshire, England. Mrs. Bennet's greatest desire is to marry off her five daughters in order to secure their futures. The arrival of Mr. Bingley, a rich bachelor who rents the neighbouring Netherfield estate, gives her hope that one of her daughters might contract an advantageous marriage, because \"It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife\".", "XXX132", new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.9m, "Pride and Prejudice" },
                    { 11, "The Shining mainly takes place in the fictional Overlook Hotel, an isolated, haunted resort hotel located in the Colorado Rockies.", "XXX133", new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.3m, "The Shining" },
                    { 12, "The Green Mile is a 1996 serial novel by American writer Stephen King. It tells the story of death row supervisor Paul Edgecombe's encounter with John Coffey, an unusual inmate who displays inexplicable healing and empathetic abilities. ", "XXX134", new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.1m, "The Green Mile" },
                    { 13, "My Brilliant Friend is a rich, intense and generous hearted story about two friends, Elena and Lila. Ferrante's inimitable style lends itself perfectly to a meticulous portrait of these two women that is also the story of a nation and a touching meditation on the nature of friendship. ", "XXX135", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.7m, "My Brilliant Friend" },
                    { 14, "Homer Wells is shown growing up in an orphanage where he spends his childhood trying to be \"of use\" as a medical assistant to director Dr. Wilbur Larch, whose history is told in flashbacks: After a traumatic misadventure with a prostitute as a young man, Wilbur turns his back on sex and love, choosing instead to help women with unwanted pregnancies give birth and then keeping the babies in an orphanage.", "XXX136", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.6m, "The Cider House Rules" },
                    { 15, "The novel is about the life of T.S. Garp. His mother, Jenny Fields, is a strong-willed nurse who wants a child but not a husband.", "XXX137", new DateTime(1978, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.4m, "The World According to Garp" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 5, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 13 },
                    { 8, 14 },
                    { 8, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PublicationDate", "Rating" },
                values: new object[] { "In 1Q84 ...", new DateTime(1988, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.2m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(1989, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PublicationDate", "Rating" },
                values: new object[] { "Bilbo was...", new DateTime(1925, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5m });
        }
    }
}
