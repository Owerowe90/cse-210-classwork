// See https://aka.ms/new-console-template for more information

Team firebirds = new Team("Firebirds");
Team whiterice = new Team("WhiteRice");

Player owen = new Player("Owen Rowe", 89);
Player mom = new Player("Your Mom", 7);
Player deez = new Player("Deez Nuts", 99);
Player john = new Player("John Henderson", 12);
Player tim = new Player("Tim Nunn", 12);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);
whiterice.AddPlayer(owen);
whiterice.AddPlayer(mom);
whiterice.AddPlayer(deez);


Match match1 = new Match(firebirds, whiterice);
match1.DecideWin();

firebirds.DisplayRoster();
whiterice.DisplayRoster();
