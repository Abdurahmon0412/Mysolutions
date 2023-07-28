using N14_2;

var events = new Planner();
events.Add("Ashuro", new TimeOnly(18, 30));
events.Add("Hayit", new TimeOnly(20, 30));
events.Add("saharlik", new TimeOnly(4,25 ));
events.Display();

var Ultimate = new UltimatePlanner();
Ultimate.Add("erta", new TimeOnly(12,30));
Ultimate.Add("asdf",new TimeOnly(12,30));
Ultimate.Add("dskjla", new DateOnly(1, 1, 1));
Ultimate.Display();
