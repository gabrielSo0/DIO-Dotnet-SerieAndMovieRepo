# Serie and Movie Catalog using POO

## Project Structure (architecture)

* **Entities**
  * This folder is used to keep all my entities or classes that i normaly will use.
* **Enum**
  * There is a file called Genre that has all the genre of movies and series, and each one has a number that represent it
* **Interface**
  * This folder keep the Repository interface that is used on the entities classes Series and Movies.

## Entities / Enum / Interface and Program

* EntityBase
  * This class is an abstraction and all my models classes has to inherit because they also have Id;
* ScreenEntertainment
  * Another abstract class that can represent a screen entertainment like movies and series. So, my Movie and Serie classes doesn't have to implement the same properties and methods, and if by chance there is a need you can implement others properties and methods.
* Movie and Serie
  * These two classes inherit from the ScreenEntertainment and only have the constructor, nothing more.
* Genre
  * With this Enum I don't need to create a object or properties for all genres of movies and series, I can rank as "Action = 1", "Horror = 13" for example.
* IRepository
  * This is interface has some methods that force the class who implement it to use. It's a generic Interface that can be used by a lot of classes as we will see below.
* MovieRepository / SerieRepository
  * So in these two classes I implement the interface IRepository, and I'm forced to declare all the methods that has in IRepository, but the advantage of using this kind of design patter is that if there is a rule on the methods os SerieRepo or MovieRepo I can change and will not effect one another.
* Program
  * There are crud methods of movie and series. We can choose if we want to add a movie or a serie. There are methods that show the options adapted for movie and series. Please, check it out. 