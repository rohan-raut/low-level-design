#include <iostream>
using namespace std;

class IButton{
    public:
    virtual void onPress() = 0;
};

class WinButton: public IButton{
    public:
    void onPress(){
        cout<<"Windows button pressed"<<endl;
    }
};

class MacButton: public IButton{
    public:
    void onPress(){
        cout<<"Mac button pressed"<<endl;
    }
};

class ITextBox{
    public:
    virtual void showText() = 0;
};

class WinTextBox: public ITextBox{
    public:
    void showText(){
        cout<<"Windows textbox"<<endl;
    }
};

class MacTextBox: public ITextBox{
    public:
    void showText(){
        cout<<"Mac textbox"<<endl;
    }
};

class IFactory{
    public:
    virtual IButton* createButton() = 0;
    virtual ITextBox* createTextBox() = 0;
};

class WinFactory: public IFactory{
    public:
    IButton* createButton(){
        return new WinButton();
    }

    ITextBox* createTextBox(){
        return new WinTextBox();
    }
};

class MacFactory: public IFactory{
    public:
    IButton* createButton(){
        return new MacButton();
    }

    ITextBox* createTextBox(){
        return new MacTextBox();
    }
};

class GUIAbstractFactory{
    public:
    static IFactory* createFactory(string osType){
        IFactory* factory = nullptr;
        if(osType == "Win"){
            factory = new WinFactory();
        }
        else if(osType == "Mac"){
            factory = new MacFactory();
        }
        else{
            cout<<"No factory found";
        }
        return factory;
    }
};


int main()
{
    string osType;
    cin>>osType;

    IFactory* factory = GUIAbstractFactory::createFactory(osType);

    if(factory != nullptr){
        IButton* button = factory->createButton();
        button->onPress();
    
        ITextBox* textBox = factory->createTextBox();
        textBox->showText();
    }
    
    
    return 0;
}