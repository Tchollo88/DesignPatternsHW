using Holloman_DesignPatternHomework;

/*
Todd Holloman

    Design Pattern: Decorator Pattern                                       Type:  Structural Pattern

A reason to use it:
    One can use it for helping to manage a project without over bloating it with to many functions or classes.

https://refactoring.guru/design-patterns/decorator
 */

Scoop icecream = new Scoop(.35m, "Vanilla", null, "Bob");
//Scoop icecream2 = new Scoop(.45m, "caramelnouget", icecream, null);
Holder cone = new Holder(.15m, "Waffle", icecream);
Topping syrup = new Topping(.1m, "Strawberry", cone);
Topping organic = new Topping(.05m, "Peanut", syrup);
Topping candy = new Topping(.05m, "Spinkles", organic);

Console.WriteLine(candy.CalaculateCost());