Why Interfaces?
-Maintainable : Code that flexes under change rather than breaking
-Extensible : Code that responds quickly to new requirements
-Testable 

Interface helps in adding a layer of Abstraction to your code.

- Used in Mocking and Dependency Injection
-----------------------------------------------------------------------
What are Interfaces?
- Interfaces describle a group of related functions that can belong to any class or struct.

-Interface is a Contract. i.e. The interface defines a contract consisting of a set of public members(Properties, Methods, Events, Indexers). 
When a class implements an interfce, it makes a commitment to fulfill that contract. To fulfill the contract, it simply supplies implementations for 
all of the interface members.

-Members are by default public. Bcoz you can't have a contract with secret requirements. Everyone needs to have visibility to all parts of 
the contract in order for it to be enforceable.

Automatic Properties : An automatic property is a shortcut syntax that we got in C# 3.0. ex: prop
When we use automatic property, the compiler generates a backing field for us. 
-propfull :code snippet for property and backing field

What's a Concrete class?
-It's just a class, the same type of class that we're used to dealing with day to day in out code.

What's an Abstract Class?
- An abstract class is a class that has one or more abstract members. An abstract member is a class member that is declared, but not implemented.

Interface
-An interface is similar to a purely Abstract class. A purely abstract class has all abstract members with no implementation at all.
-Interfaces are only allowed to have declarations, the parts of the contract, and no implementation. It,s up to the class implementing 
the contract to provide the details.

-- If a C# class does not specify a base class, then it automatically inherits from Object.

ConcreteClass,Abstract Class, Interface?
-Concrete Class : No Compile-time checking

-Abstract Class, Interface : Force us to provide a implementation, if we dont provide we get compile time error, compile-time checking

--Comparison : Implementaion Code
---Abstract classes may contain implementation
---Interfaces can not contain implementation (declarations only)

--Comparison : Inheritance
---Inherit from a single Abstract Class (Single Inheritance)
--- Implement any number of Interfaces

--Comparison : Access Modifiers
--- Abstract classes members can have access modifiers
--- Interface members are automatically public. bcoz we want all of our contract terms to be visible to everyone involved.

--Comparison : Valid Members
---Abstract Classes
	Fields
	Constructors
	Destructors
	Properties
	Methods
	Events
	Indexers
---Interfaces
	Properties
	Methods
	Events
	Indexers
	
- The Abstract Class's biggest strength is that it can contain implementation code that's shared among all of the child classes. 
This is extremely useful when a method or property will be implemented exactly the same way in each child class, but the biggest 
weakness of the Abstract Class is single inheritance.

-The Interface's biggest strength is that it is not affected by single inheritance. We can add an interface to any class, even 
if it is already inheriting from some other class, and it doesn't matter if that class implements other interfaces, it can 
implement as many as we need, but the biggest weakness of an interface is that there's no shared implementation code allowed.

------------------------------------------------------------------------------------------------------------------------------------
~~~~~~~~~Using Interfaces to Future-Proof Code~~~~~~~~~~~
- Best Practice : Program to an abstraction rather than a concrete type
					=> Program to an interface rather than concrete class

- Interface Segregation Principle: e.g. List<T> implements 8 interfaces and each of these interfaces represents a different group of functionality.

-IEnumerable contains GetEnumberator : it specifies the ability to iterate over a collection, that is loop through the list and get back each item in turn.
IEnumerable is quite a useful interface. It allows us to use the foreach loop on an Object and its also used when loading a collection into a List Box




