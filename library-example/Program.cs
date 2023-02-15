Book book = new Book("Maze Runner", "9783837383", "234546378");
Book book2 = new Book("Eragon", "12345687899", "123473958");

Dvd dvd1 = new Dvd("Flushed Away", 15, "Comedy");
Dvd dvd2 = new Dvd("Lord of the Rings", 5, "Action");
Dvd dvd3 = new Dvd("Star Wars", 3, "Sci-fi");

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();

book.ShowBookDeets();
book2.ShowBookDeets();

dvd1.ShowDvdDeets();
dvd2.ShowDvdDeets();
dvd3.ShowDvdDeets();

Dvd.DvdAmount();

