using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Subject_SetState_StateIsSet()
        {
            // Arrange
            var subject = new Subject();

            // Act
            subject.SetState("Test State");

            // Assert
            Assert.AreEqual("Test State", subject.GetState());
        }

        [TestMethod]
        public void TimeObserver_Update_CorrectElapsedTime()
        {
            // Arrange
            var subject = new Subject();
            var outputTextBox = new System.Windows.Forms.TextBox();
            var timeObserver = new TimeObserver(subject, outputTextBox);
            timeObserver.SetStartTime();

            // Act
            System.Threading.Thread.Sleep(1000); // Simulate time passing
            timeObserver.Update();

            // Assert
            Assert.IsTrue(outputTextBox.Text.Contains("Elapsed time since state change: 1 seconds"));
        }

        [TestMethod]
        public void TestSubjectNotify()
        {
            Subject subject = new Subject();
            TextBox outputTextBox = new TextBox();
            TimeObserver timeObserver = new TimeObserver(subject, outputTextBox);
            CountObserver countObserver = new CountObserver(subject, outputTextBox);

            subject.Attach(timeObserver);
            subject.Attach(countObserver);

            subject.SetState("Some State");

            // Assert that the outputTextBox contains the expected text
            string expectedText = "TimeObserver: Elapsed time since state change: 0 seconds\n" +
                                  "CountObserver: Found state 'Some State'. Count: 1\n";
            Assert.AreEqual(expectedText, outputTextBox.Text);
        }

        [TestMethod]
        public void Subject_NotifyObservers_ObserversNotified()
        {
            // Arrange
            var subject = new Subject();
            var observer1 = new TimeObserver(subject, new System.Windows.Forms.TextBox());
            var observer2 = new CountObserver(subject, new System.Windows.Forms.TextBox());
            subject.Attach(observer1);
            subject.Attach(observer2);

            // Act
            subject.Notify();

            // Assert
            // Check if both observers were notified
            // This depends on the implementation of Update method in each observer
        }

        [TestMethod]
        public void TimeObserver_SetStartTime_StartTimeSet()
        {
            // Arrange
            var subject = new Subject();
            var outputTextBox = new System.Windows.Forms.TextBox();
            var timeObserver = new TimeObserver(subject, outputTextBox);

            // Act
            timeObserver.SetStartTime();

            // Assert
            // Check if _startTime is set to current time
        }

        [TestMethod]
        public void CountObserver_Update_NoIncrementWhenStateDoesNotChange()
        {
            // Arrange
            var subject = new Subject();
            var outputTextBox = new System.Windows.Forms.TextBox();
            var countObserver = new CountObserver(subject, outputTextBox);

            // Act
            subject.SetState("Some State");
            subject.Notify(); // First time
            subject.Notify(); // Second time with same state

            // Assert
            Assert.IsFalse(outputTextBox.Text.Contains("Found state 'Some State'. Count: 2"));
        }
    }
}
