using Practice13_2;

var EventManagerO =  new EventManager();
EventManagerO.Add("Mustaqillik", new DateOnly(2023, 07, 27));
EventManagerO.Add("Mustaqillik tugagan ", new DateOnly(2023, 07, 28));
EventManagerO.Add("Hiayit", new DateOnly(2023, 07, 29));
EventManagerO.Add("Meting", new TimeOnly(14,10,39, 0));
EventManagerO.Add("Abid", new TimeOnly(12, 10, 39, 0));
EventManagerO.Add("Dars", new TimeOnly(18, 10, 39, 0));

EventManagerO.Display();


