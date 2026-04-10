using NUnit.Framework;
using UnityEngine;

// 네임스페이스 없이 작성하여 접근성을 높입니다.
public class MyGameTests
{
    [Test]
    public void SimpleArithmeticTest()
    {
        int expected = 0;
        int actual = 10 + 20;
        // 일부러 실패를 보고 싶다면 expected를 0으로 바꾸세요.
        Assert.AreEqual(expected, actual);
    }
}