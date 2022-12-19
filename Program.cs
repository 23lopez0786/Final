List<Animal> animal = new List<Animal>();


Animal Dogg = new Animal();
Dogg.name = "jeff";
Dogg.color = "red";
Dogg.breed = "husky";
animal.Add(Dogg);

cat Catt = new cat();
Catt.name = "hen";
Catt.color = "brown";
Catt.breed = "garfeild";
animal.Add(Catt);

tiger Tigerr = new tiger();
Tigerr.name = "Gary";
Tigerr.color = "White";
Tigerr.breed = "Snow tiger";
animal.Add(Tigerr);


Console.WriteLine(animal.Count);