====================================================
Task 2: Zoo-Registration-System (create new github gepo )
====================================================

A zoo is building a small internal system to register animals and track basic operational rules.
The zoo has two animal categories for now:
Mammals
Birds

They want shared fields (like Name, Age) but also category-specific details.

Requirements
1) Base Class: Animal
Create a base class Animal with:

Required Fields / Properties

Id (auto-generated)
Name (cannot be empty)
Age (must be >= 0)

Rules

Id must be auto-generated using a static counter
Name and Age must be validated in the constructor (and/or property setters)

Constructor Requirements
Animal(string name, int age) must initialize and validate required fields.


2) Derived Class: Mammal : Animal

Add:
FurColor (cannot be empty)
IsCarnivore (bool)
Constructor must call base constructor:
Mammal(string name, int age, string furColor, bool isCarnivore)

Validation:
FurColor cannot be blank.

3) Derived Class: Bird : Animal
Add:
WingSpanCm (must be > 0)
CanFly (bool)
Constructor must call base constructor:
Bird(string name, int age, int wingSpanCm, bool canFly)

Validation:
WingSpanCm must be positive.

4) Collections Handling (No Polymorphism Allowed)

store animals in separate collections:
List<Mammal> mammals
List<Bird> birds

5) Output Requirements

In Program.Main (separate Program class):
Create at least 2 mammals and 2 birds
Add them to their respective lists
Print a clean report like:
example output  , 
---- ZOO REGISTER ----

MAMMALS:
ID: 1 | Name: Leo | Age: 5 | FurColor: Golden | Carnivore: True
ID: 2 | Name: Molly | Age: 2 | FurColor: Brown | Carnivore: False

BIRDS:
ID: 3 | Name: Coco | Age: 1 | WingSpanCm: 30 | CanFly: True
ID: 4 | Name: Pingu | Age: 4 | WingSpanCm: 50 | CanFly: False

Total Animals Registered: 4
