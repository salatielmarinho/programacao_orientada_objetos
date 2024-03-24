# Fundamentos de Programa��o Orientada � Objetos

Polimorfismo, em programa��o orientada a objetos, refere-se � capacidade de objetos de diferentes classes terem a mesma interface ou seja, possu�rem m�todos com o mesmo nome e assinatura, mas com implementa��es diferentes. Isso � poss�vel gra�as a heran�a e aos m�todos virtuais.

Existem dois tipos de polimorfismo:

Polimorfismo Compilado (Static): ocorre em tempo de compila��o, quando a linguagem de programa��o � capaz de determinar o tipo exato do objeto e chamar a implementa��o correta do m�todo.
Polimorfismo Din�mico (Dynamic): ocorre em tempo de execu��o, quando a linguagem de programa��o � incapaz de determinar o tipo exato do objeto e precisa utilizar t�cnicas de vtable ou dispatching para chamar a implementa��o correta do m�todo.
Em C#, o polimorfismo est�tico pode ser alcan�ado atrav�s de sobrecarga (overloading) de m�todos, enquanto que o polimorfismo din�mico pode ser alcan�ado atrav�s de sobreposi��o (overriding) de m�todos.

Aqui est� um exemplo de polimorfismo em C#:

```ruby
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog();
        animal.MakeSound(); // outputs "Dog barks"

        animal = new Cat();
        animal.MakeSound(); // outputs "Cat meows"
    }
}
```

Neste exemplo, a classe Animal define um m�todo virtual MakeSound(). A classe Dog e a classe Cat herdam da classe Animal e sobrep�em o m�todo MakeSound() com implementa��es diferentes. Na classe Program, um objeto de tipo Animal � criado e inicializado com inst�ncias de Dog e Cat, respectivamente. O m�todo MakeSound() � chamado em cada objeto, e o polimorfismo permite que a implementa��o correta do m�todo seja chamada dinamicamente durante a execu��o.

O polimorfismo � uma caracter�stica importante da programa��o orientada a objetos, pois permite que os objetos se comportem de forma flex�vel e redirecion�vel, tornando o c�digo mais simples e f�cil de manter.