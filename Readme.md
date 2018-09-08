Why Interfaces?
-Maintainable : Code that flexes under change rather than breaking
-Extensible : Code that responds quickly to new requirements
-Testable 

Interface helps in adding a layer of Abstraction to your code.

- Used in Mocking and Dependency Injection
-----------------------------------------------------------------------
What are Interfaces?
- Interfaces describle a group of related functions that can belong to any class or struct.

-Interface is a Contract. i.e. The interface defines a contract consisting of a set of public members(Properties, Methods, Events, Indexers). When a class implements an interfce, it makes a commitment to fulfill that contract. To fulfill the contract, it simply supplies implementations for all of the interface members.

-Members are by default public. Bcoz you can't have a contract with secret requirements. Everyone needs to have visibility to all parts of the contract in order for it to be enforceable.

Automatic Properties : An automatic property is a shortcut syntax that we got in C# 3.0. ex: prop
When we use automatic property, the compiler generates a backing field for us. 
-propfull :code snippet for property and backing field

What's a Concrete class?
-It's just a class, the same type of class that we're used to dealing with day to day in out code.

What's an Abstract Class?
- An abstract class is a class that has one or more abstract members. An abstract member is a class member that is declared, but not implemented.

Interface
-An interface is similar to a purely Abstract class. A purely abstract class has all abstract members with no implementation at all.
-Interfaces are only allowed to have declarations, the parts of the contract, and no implementation. It,s up to the class implementing the contract to provide the details.

-- If a C# class does not specify a base class, then it automatically inherits from Object.