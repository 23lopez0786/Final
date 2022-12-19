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

/*
 * Program Name: Animal List
 * Programmer: Seth Lopez
 * Date: 12/19/2022
 *
 * Description:The way this code works is by creating a list you can then create objects, give
those objects names and give them the attributes like the name color and breed
after doing this you will want to add this object to the list and you do this 
by using .Add. 
So the way the C# code works is by creating the strings name color and breed
and making them equal to the paramaters n, c, b and then you derive the Animal
class by using the :. After doing this you are able to pass these parameters to the derivied 
classes and use them in the Cat and Tiger classes.

 */