# Object Oriented Programming C++ Notes

## Visibility in Inheritance

Members\Visibility | Private | Public | Protected
--- |--- |--- |---
Private members | Not Inherited | Not Inherited | Not Inherited 
Public members | Private | Public | Protected
Protected members | Private | Protected | Protected

Private members of the class cannot be directly inherited in the derived class instead to access the private members of the base class we need to create the public getter and setter methods.

---

## Ambibuity in Multiple Inheritance

When all the base class have the same member or function names then the derived class doesn't know whose which base class member or function to access. This is ambibuity.

Ways to resolve ambibuity:
- If it is a function, override it in the derived class.
- If it is a function, create a same function in derived class and specify which base function to call. Syntax: ```BaseA :: greet();``` This will call the BaseA greet function.

## Virtual Base Class

    Hybrid Inheritance

                    Class A
                _______|______
                |             |
             Class B        Class C
                |_____________|
                       |
                     Class D


```cpp
class A{
    public:
    int var;
};

class B: public A{
    // code
};

class C: public A{
    // code
};

class D: public B, public C{
    public:
    void getVar(){
        cout<<var<<endl;
    }
};
```

In the above example, the var will be inherited twice in class D, one from class B and other from class C. To avoid this ambibuity use virtual keyword while deriving the class D;

```cpp
class A{
    public:
    int var;
};

class B: virtual public A{
    // code
};

class C: virtual public A{
    // code
};

class D: public B, public C{
    public:
    void getVar(){
        cout<<var<<endl;
    }
};
```

Class A is not called as virtual base class.
For a good practise try to avoid multiple inheritance and use abstract class instead.


## Constructor call in Inheritance


