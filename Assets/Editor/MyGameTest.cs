using NUnit.Framework;

[TestFixture] // 이 속성을 추가해보세요.
public class MyGameTest
{
    [Test]
    public void SimplePassTest()
    {
        Assert.AreEqual(3, 10 + 20); // 0 == 30 실패 케이스
    }
}