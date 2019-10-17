using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringwithConfidence1_9.Fundamentals;

namespace ReservationTests1_9
{
    [TestClass]
    public class ReservationTests
    {
    [TestMethod]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        //Arrage
        var reservation = new Reservation();

        //Act
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //Assert

        Assert.IsTrue(result);
    }
        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_Return()
    {
        var user = new User();
        var reservation = new Reservation { MadeBy = user };

        var result = reservation.CanBeCancelledBy(user);

        Assert.IsTrue(result);
    }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_RetureFalse()
    {
        var reservation = new Reservation { MadeBy = new User() };

        var result = reservation.CanBeCancelledBy(new User());

        Assert.IsFalse(result);
    }
       
        [TestMethod]
         public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {

        }
    

        [TestMethod]
        public void CanBeCancelledBy_SameUseCancelling_ReturnTrue()
        {

        }
    
        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {

        }
       
    }
}
