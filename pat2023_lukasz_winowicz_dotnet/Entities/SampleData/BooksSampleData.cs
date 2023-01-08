namespace pat2023_lukasz_winowicz_dotnet.Entities.SampleData
{
    public static class BooksSampleData
    {
        public static IList<Book> sampleBooks = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "1Q84 Tom 1",
                Description = "This is the first novel in which Murakami takes up the risky topic of fringe " +
                "religious groups—a sore spot in Japan since the Aum Shinrikyō terrorist attack of 1995.",
                Rating = Convert.ToDecimal(7.5),
                ISBN = "XXX123",
                PublicationDate = new DateTime(2009, 1, 1),
            },
            new Book
            {
                Id = 2,
                Title = "1Q84 Tom 2",
                Description = "In 1Q84 ...",
                Rating = Convert.ToDecimal(7.5),
                ISBN = "XXX124",
                PublicationDate = new DateTime(2010, 1, 1),
            },
            new Book
            {
                Id = 3,
                Title = "Hobbit",
                Description = "Bilbo Baggins, the protagonist, is a respectable, " +
                "reserved hobbit—a race resembling short humans with furry, " +
                "leathery feet who live in underground houses and are mainly pastoral farmers and gardeners.",
                Rating = Convert.ToDecimal(6.8),
                ISBN = "XXX125",
                PublicationDate = new DateTime(1937, 1, 1),
            },
            new Book
            {
                Id = 4,
                Title = "Kafka on the Shore",
                Description = "Surely the most confusing of all Murakami novels, this one has three protagonists, each from a different generation.",
                Rating = Convert.ToDecimal(7.5),
                ISBN = "XXX126",
                PublicationDate = new DateTime(2002, 1, 1),
            },
            new Book
            {
                Id = 5,
                Title = "The Lord of the Rings",
                Description = "The Lord of the Rings is an epic[1] high-fantasy novel[a] by English author and scholar J. R. R. Tolkien. Set in Middle-earth, " +
                "intended to be Earth at some time in the distant past, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, " +
                "The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.",
                Rating = Convert.ToDecimal(9.2),
                ISBN = "XXX127",
                PublicationDate = new DateTime(1954, 1, 1),
            },
            new Book
            {
                Id = 6,
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "Harry Potter lives with his abusive aunt and uncle, Vernon and Petunia Dursley and their bullying son, Dudley. On Harry's eleventh birthday, " +
                "a half-giant named Rubeus Hagrid personally delivers an acceptance letter to Hogwarts School of Witchcraft and Wizardry, revealing that Harry's parents, James and Lily Potter, " +
                "were wizards. When Harry was one year old, an evil and powerful dark wizard, Lord Voldemort, murdered his parents. " +
                "Harry survived Voldemort's killing curse that rebounded off his forehead and seemingly destroyed the Dark Lord, leaving a lightning bolt-shaped scar on his forehead. " +
                "Unknown to Harry, he is famous in the wizarding world",
                Rating = Convert.ToDecimal(8.8),
                ISBN = "XXX128",
                PublicationDate = new DateTime(1997, 1, 1),
            },
            new Book
            {
                Id = 7,
                Title = "Harry Potter and the Chamber of Secrets",
                Description = "While spending the summer at the Dursleys, twelve-year-old Harry Potter is visited by a house-elf named Dobby. " +
                "He warns that Harry is in danger and must not return to Hogwarts. Harry refuses, so Dobby magically ruins Aunt Petunia and Uncle Vernon's dinner party.",
                Rating = Convert.ToDecimal(8.6),
                ISBN = "XXX129",
                PublicationDate = new DateTime(1998, 1, 1),
            },
            new Book
            {
                Id = 8,
                Title = "The Sun Also Rises",
                Description = "On the surface, the novel is a love story between the protagonist Jake Barnes—a man whose war wound has made him unable to have sex—and the promiscuous divorcée Lady Brett Ashley.",
                Rating = Convert.ToDecimal(7.3),
                ISBN = "XXX130",
                PublicationDate = new DateTime(1926, 1, 1),
            },
            new Book
            {
                Id = 9,
                Title = "For Whom the Bell Tolls",
                Description = "Robert Jordan is an American, formerly a professor of Spanish language at the University of Montana. " +
                "He had lived in prewar Spain, and fights as an irregular soldier for the Republic against Francisco Franco's fascist forces. ",
                Rating = Convert.ToDecimal(8.4),
                ISBN = "XXX131",
                PublicationDate = new DateTime(1940, 1, 1),
            },
            new Book
            {
                Id = 10,
                Title = "Pride and Prejudice",
                Description = "In the early 19th century, the Bennet family live at their Longbourn estate, situated near the village of Meryton in Hertfordshire, " +
                "England. Mrs. Bennet's greatest desire is to marry off her five daughters in order to secure their futures. " +
                "The arrival of Mr. Bingley, a rich bachelor who rents the neighbouring Netherfield estate, gives her hope that one of her daughters might contract an advantageous marriage, because" +
                " \"It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife\".",
                Rating = Convert.ToDecimal(8.9),
                ISBN = "XXX132",
                PublicationDate = new DateTime(1813, 1, 1),
            },
            new Book
            {
                Id = 11,
                Title = "The Shining",
                Description = "The Shining mainly takes place in the fictional Overlook Hotel, an isolated, haunted resort hotel located in the Colorado Rockies.",
                Rating = Convert.ToDecimal(8.3),
                ISBN = "XXX133",
                PublicationDate = new DateTime(1977, 1, 1),
            },
            new Book
            {
                Id = 12,
                Title = "The Green Mile",
                Description = "The Green Mile is a 1996 serial novel by American writer Stephen King. " +
                "It tells the story of death row supervisor Paul Edgecombe's encounter with John Coffey, " +
                "an unusual inmate who displays inexplicable healing and empathetic abilities. ",
                Rating = Convert.ToDecimal(9.1),
                ISBN = "XXX134",
                PublicationDate = new DateTime(1996, 1, 1),
            },
            new Book
            {
                Id = 13,
                Title = "My Brilliant Friend",
                Description = "My Brilliant Friend is a rich, intense and generous hearted story about two friends, Elena and Lila. " +
                "Ferrante's inimitable style lends itself perfectly to a meticulous portrait of these two women that is also the story of a nation and " +
                "a touching meditation on the nature of friendship. ",
                Rating = Convert.ToDecimal(8.7),
                ISBN = "XXX135",
                PublicationDate = new DateTime(2011, 1, 1),
            },
            new Book
            {
                Id = 14,
                Title = "The Cider House Rules",
                Description = "Homer Wells is shown growing up in an orphanage where he spends his childhood trying to be \"of use\" as a medical assistant to director Dr. " +
                "Wilbur Larch, whose history is told in flashbacks: After a traumatic misadventure with a prostitute as a young man, " +
                "Wilbur turns his back on sex and love, choosing instead to help women with unwanted pregnancies give birth and then keeping the babies in an orphanage.",
                Rating = Convert.ToDecimal(8.6),
                ISBN = "XXX136",
                PublicationDate = new DateTime(1985, 1, 1),
            },
            new Book
            {
                Id = 15,
                Title = "The World According to Garp",
                Description = "The novel is about the life of T.S. Garp. His mother, Jenny Fields, is a strong-willed nurse who wants a child but not a husband.",
                Rating = Convert.ToDecimal(9.4),
                ISBN = "XXX137",
                PublicationDate = new DateTime(1978, 1, 1),
            }

        };
    }
}
