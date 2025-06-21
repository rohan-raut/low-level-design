#include <iostream>
#include <string>

using namespace std; 

// Clone Interface
class Clone {
public:
    virtual Clone* clone() = 0;
    virtual ~Clone() {}
};

// ClassA
class ClassA : public Clone {
public:
    int* value;

    ClassA(int v = 1) {
        value = new int(v);
    }

    ClassA(const ClassA& other) {
        value = new int(*other.value);
    }

    virtual ~ClassA() {
        delete value;
    }

    virtual void print() {
        cout << "ClassA -> value: " << *value << " at " << value << endl;
    }

    Clone* clone() override {
        return new ClassA(*this);
    }
};

// ClassB (inherits ClassA)
class ClassB : public ClassA {
public:
    float* score;

    ClassB(int v = 2, float s = 2.5f) : ClassA(v) {
        score = new float(s);
    }

    ClassB(const ClassB& other) : ClassA(other) {
        score = new float(*other.score);
    }

    ~ClassB() override {
        delete score;
    }

    void print() override {
        ClassA::print();
        cout << "ClassB -> score: " << *score << " at " << score << endl;
    }

    Clone* clone() override {
        return new ClassB(*this);
    }
};

// ClassC (inherits ClassB)
class ClassC : public ClassB {
public:
    string* name;

    ClassC(int v = 3, float s = 3.5f, string n = "Default") : ClassB(v, s) {
        name = new string(n);
    }

    ClassC(const ClassC& other) : ClassB(other) {
        name = new string(*other.name);
    }

    ~ClassC() override {
        delete name;
    }

    void print() override {
        ClassB::print();
        cout << "ClassC -> name: " << *name << " at " << name << endl;
    }

    Clone* clone() override {
        return new ClassC(*this);
    }
};

int main()
{
    cout << "Original object:\n";
    ClassC original(10, 99.5f, "Prototype");
    original.print();

    cout << "\nCloned object:\n";
    Clone* cloned = original.clone();

    ClassC* clonedC = (ClassC*) cloned;

    if (clonedC) {
        clonedC->print();
    }

    // Modify the cloned object's data
    *(clonedC->value) = 20;
    *(clonedC->score) = 55.5f;
    *(clonedC->name) = "Cloned";

    cout << "\nAfter modifying cloned object:\n";
    cout << "Original:\n";
    original.print();
    cout << "Cloned:\n";
    clonedC->print();

    delete cloned;
    return 0;

}