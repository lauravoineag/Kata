using NUnit.Framework;

namespace PasswordValidation;

public class TestPasswordValidation
{
    private PasswordValidation _sut;//subject under test

    [SetUp]
    public void set_up()
    {
        _sut = new PasswordValidation();//instance of class we are testing
    }

    [Test]
    public void is_not_empty()
    {
        //arrange
         string password = "";
        //act
        var result = _sut.Validation(password);//calling method under test
        //assert
        Assert.That(result, Is.False);
    }
    [Test]
    public void is_not_null()//check tht you have given me a string
    {
        //arrange
        string password = null;
        //act
        var result = _sut.Validation(password);//calling method under test
        //assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void is_valid_password()
    {
        //arrange
        string password = "123456_xA";
        //act
        var result = _sut.Validation(password);
        //assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void must_have_more_than_8_characters()
    {
        //arrange
        string eightCharacterPassword = "1234_xA";
        //act
        var result = _sut.Validation(eightCharacterPassword);
        //assert
        Assert.That(result, Is.False);
    }
    [Test]
    public void must_have_1_capital_character()
    {
        //arrange
        string noCapitalCharacter = "1234567_x";
        //act
        var result = _sut.Validation(noCapitalCharacter);
        //assert
        Assert.That(result, Is.False );
    }
    
    [Test]
    public void must_have_1_lowercase_character()
    {
        //arrange
        string noCapitalCharacter = "1234567_A";
        //act
        var result = _sut.Validation(noCapitalCharacter);
        //assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void must_have_1_number()
    {
        //arrange
        string oneNumber = "xxxxxx_xA";
        //act
        var result = _sut.Validation(oneNumber);
        //assert
        Assert.That(result, Is.False);
    }
    [Test]
    public void must_have_underscore_character()
    {
        //arrange
        string oneNumber = "1234567xA";
        //act
        var result = _sut.Validation(oneNumber);
        //assert
        Assert.That(result, Is.False);
    }
}
