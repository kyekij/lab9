using NUnit.Framework;
using System;
using WindowsFormsApp1;
using System.Windows.
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Subject_SetState_StateIsSet()
        {
            // Arrange
            var subject = new Subject();

            // Act
            subject.SetState("Test State");

            // Assert
            Assert.AreEqual("Test State", subject.GetState());
        }

        [Test]
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

        [Test]
        public void CountObserver_Update_IncrementCount()
        {
            // Arrange
            var subject = new Subject();
            var outputTextBox = new System.Windows.Forms.TextBox();
            var countObserver = new CountObserver(subject, outputTextBox);

            // Act
            subject.SetState("Some State");
            subject.Notify();
            subject.SetState("Some Other State");
            subject.Notify();
            subject.SetState("Some State");
            subject.Notify();

            // Assert
            Assert.IsTrue(outputTextBox.Text.Contains("Found state 'Some State'. Count: 2"));
        }

        [Test]
        public void Subject_AttachObserver_ObserverAdded()
        {
            // Arrange
            var subject = new Subject();
            var observer = new TimeObserver(subject, new System.Windows.Forms.TextBox());

            // Act
            subject.Attach(observer);

            // Assert
            Assert.Contains(observer, subject.GetObservers());
        }

        [Test]
        public void Subject_DetachObserver_ObserverRemoved()
        {
            // Arrange
            var subject = new Subject();
            var observer = new TimeObserver(subject, new System.Windows.Forms.TextBox());
            subject.Attach(observer);

            // Act
            subject.Detach(observer);

            // Assert
            Assert.IsFalse(subject.GetObservers().Contains(observer));
        }

        [Test]
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

        [Test]
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

        [Test]
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
       