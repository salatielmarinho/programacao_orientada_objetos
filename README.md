# Fundamentos de Programação Orientada à Objetos

Polimorfismo, em programação orientada a objetos, refere-se à capacidade de objetos de diferentes classes terem a mesma interface ou seja, possuírem métodos com o mesmo nome e assinatura, mas com implementações diferentes. Isso é possível graças a herança e aos métodos virtuais.

Existem dois tipos de polimorfismo:

Polimorfismo Compilado (Static): ocorre em tempo de compilação, quando a linguagem de programação é capaz de determinar o tipo exato do objeto e chamar a implementação correta do método.
Polimorfismo Dinâmico (Dynamic): ocorre em tempo de execução, quando a linguagem de programação é incapaz de determinar o tipo exato do objeto e precisa utilizar técnicas de vtable ou dispatching para chamar a implementação correta do método.
Em C#, o polimorfismo estático pode ser alcançado através de sobrecarga (overloading) de métodos, enquanto que o polimorfismo dinâmico pode ser alcançado através de sobreposição (overriding) de métodos.

Aqui está um exemplo de polimorfismo em C#:

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

Neste exemplo, a classe Animal define um método virtual MakeSound(). A classe Dog e a classe Cat herdam da classe Animal e sobrepõem o método MakeSound() com implementações diferentes. Na classe Program, um objeto de tipo Animal é criado e inicializado com instâncias de Dog e Cat, respectivamente. O método MakeSound() é chamado em cada objeto, e o polimorfismo permite que a implementação correta do método seja chamada dinamicamente durante a execução.

O polimorfismo é uma característica importante da programação orientada a objetos, pois permite que os objetos se comportem de forma flexível e redirecionável, tornando o código mais simples e fácil de manter.