# Note 01 - Curly Bracket Syntax

## Defination

 It starts a scope for the objects that will be contained. _Related examples will be in the following document lines._

# Note 02 - Namespace Syntax

## Defination

 It defines an alias to reach out the related object/objects. It can be used multiple for in different or same files.

## Naming Convension

```csharp

// ...

namespace <Project Name>.<Folder Hierarchy If Exists>
{
    // ...
}

// ...

``````

## Example 01

**File Path**: ./Lesson 001/Model/School/Student.cs

**Namespace**: _Lesson_001.Model.School_

## Example 02

**File Path**: ./Lesson 001/Program.cs

**Namespace**: _Lesson_001_

# Note 03 - Using Syntax

## Defination

 If you want to use the object/objects in the related namespace, you should add this syntax at the top of file. <ins>You should be careful about that this is a global defination. That is, the whole code will be compiled with this prefix for each object in the following lines.</ins>

## Example 01

```csharp

using MyPersonalNameSpace;
// usings...

namespace CurrentProjectName
{
    // ...
}

// ...

```

# Note 04 - Access Modifiers

 The related document is here "https://www.w3schools.com/cs/cs_access_modifiers.php" but we just need to learn **public** and **private** for now. **_Do not learn more than this!_**

## Public

 You can access the object from everywhere you want. _There is no limit._

## Private

 You can only access the object in <ins>the related scope</ins>. If you try to access it out of the scope, the code will throw a protection error.

## Example

```csharp

public class Object1
{
    private string _variable1;
    public string Variable2;
}

public class Object2
{
    public void TestMethod1()
    {
        Object1 obj1 = new Object1();
        obj1._variable1 = "Value 1"; // This line will throw a compiling exception! That means, red line will be shown under this line!
        obj1.Variable2 = "Value 2"; // There is nothing wrong.
    }
}


```

> NOTE: Look at the variable names. One of them started with <ins>underscore</ins> and then <ins>lowercase</ins>. Other one started with <ins>upper case</ins>. This is a naming convension. Just pretend when you declare an object with these access modifiers. When you join a project, just examine the previous examples and keep the same naming convension.

# Note 05 - Files

 When you want to create an object/objects, you need to create a file with an extension ".cs".

## Example

1. **Student.cs**
2. **Model/School/Student.cs**
3. **Class.cs**
4. **Model/School/Class.cs**

# Note 06 - Constractor

## Defination

 The corresposing document is here "https://www.w3schools.com/cs/cs_constructors.php". It helps you on the management of instance of a class.

## Example

```csharp
namespace Lesson_001.Model.School
{
    class Class
    {
        // Field
        public string Name = null;
        // Field
        public Student Student1 = null;
        // Field
        public Student Student2 = null;
        // Field
        public Student Student3 = null;

        // Constractor
        public Class(string name, Student student1, Student student2, Student student3)
        {
            // We force the developer on giving those arguments to create a class instance!
        }
    }
}
```

> You can create multiple constractor!



```csharp
namespace Lesson_001.Model.School
{
    class Class
    {
        // Field
        public string Name = null;
        // Field
        public Student Student1 = null;
        // Field
        public Student Student2 = null;
        // Field
        public Student Student3 = null;

        // Constractor 01
        public Class(string name, Student student1, Student student2, Student student3)
        {
            // ...
        }

        // Constractor 02
        public Class(string name)
        {
            // ...
        }
    }
}
```

# Note 07 - Methods

## Defination

 The function depends on an object.

## Example

```csharp
using ...

namespace ...
{
    class ...
    {
        public ReturnType MethodName(ParameterType parameter1, ...)
        {
            // Code
        }
    }
}
```

# Note 08 - Define A Variable

## Defination

 In order to store a value on RAM, you need to define a variable. There are some variable types but you will learn futhermore.

## Example

```csharp
using ...

namespace ...
{
    class ...
    {
        void method()
        {
            VariableType variableName = VariableValue;
        }
    }
}
```