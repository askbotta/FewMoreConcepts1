using FewMoreConcepts1;
using System.Diagnostics.Contracts;


class Hello
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "test";
        Console.WriteLine("Structs ::" + person.Name);

        Methametical methametical = new Methametical();
        methametical.AddTwoNumber();

        MixDataTypes mixDataTypes = new MixDataTypes();
        mixDataTypes.AddMixDataTypes();

        Addition addition = new Addition();
        addition.AddTwoNumberWithPerentheses();

        BasicMathsOperations basicMathsOperations = new BasicMathsOperations();
        basicMathsOperations.BasicMathsOperations1();

        FractionalDigits fractionalDigits = new FractionalDigits();
        fractionalDigits.fraction();

        IntegerDivision integerDivision = new IntegerDivision();
        integerDivision.IntegerDivision1();

        RemainderaAfterIntegerDivision remainderaAfterIntegerDivision = new RemainderaAfterIntegerDivision();
        remainderaAfterIntegerDivision.RemainderaAfterIntegerDivision1();

        OrderOfOperations orderOfOperations = new OrderOfOperations();
        orderOfOperations.OrderOfOperation1();

        IncrementAndDecrementAValue incrementAndDecrementAValue = new IncrementAndDecrementAValue();
        incrementAndDecrementAValue.IncrementAndDecrementAValue1();

        IncrementOperatorBeforeAndAfterTheValue incrementOperatorBeforeAndAfterTheValue = new IncrementOperatorBeforeAndAfterTheValue();
        incrementOperatorBeforeAndAfterTheValue.IncrementOperatorBeforeAndAfterTheValue1();

        TemperatureInFahrenheit temperatureInFahrenheit = new TemperatureInFahrenheit();
        temperatureInFahrenheit.Temp();

        GuidedProjectData guidedProjectData = new GuidedProjectData();
        guidedProjectData.SumOfSubjects();

        StudentCourseAndName studentCourseAndName = new StudentCourseAndName();
        studentCourseAndName.Student();



        Console.ReadKey();

    }
}