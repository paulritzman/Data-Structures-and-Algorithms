using AnimalShelter.Classes;
using System;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPeekAtFrontOfAnimalShelterQueue()
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            shelter.Enqueue(new Node(new Cat()));

            Node firstAnimalInShelter = shelter.Peek();

            Assert.Equal("cat", firstAnimalInShelter.Name);
        }

        [Theory]
        [InlineData("cat")]
        [InlineData("dog")]
        public void CanEnqueueDogAndDogObjectsIntoShelter(string newAnimal)
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            if (newAnimal == "cat")
            {
                shelter.Enqueue(new Node(new Cat()));
            }
            else
            {
                shelter.Enqueue(new Node(new Dog()));
            }

            Assert.Equal(newAnimal, shelter.Rear.Name);
        }

        [Theory]
        [InlineData("cat1")]
        [InlineData("d0g")]
        [InlineData("")]
        public void AnimalShelterCanRemainEmptyIfDogOrCatNotInput(string userInput)
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            if (userInput == "cat")
            {
                shelter.Enqueue(new Node(new Cat()));
            }
            else if (userInput == "dog")
            {
                shelter.Enqueue(new Node(new Dog()));
            }

            Assert.Null(shelter.Front);
        }

        [Theory]
        [InlineData("cat")]
        [InlineData("dog")]
        public void CanDequeueAnimalFromShelter(string newAnimal)
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            if (newAnimal == "cat")
            {
                shelter.Enqueue(new Node(new Cat()));
            }
            else if (newAnimal == "dog")
            {
                shelter.Enqueue(new Node(new Dog()));
            }

            Node returnedNode = shelter.Dequeue("");

            Assert.Equal(newAnimal, returnedNode.Name);
        }

        [Fact]
        public void CanReturnNullWhenDequeueDoesNotReturnAnimalFromShelter()
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            Node returnedNode = shelter.Dequeue("");

            Assert.Null(returnedNode);
        }

        [Fact]
        public void ShelterCanReturnNullIfShelterIsEmptyUponDequeue()
        {
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            Node returnedNode = shelter.Dequeue("");

            Assert.Null(returnedNode);
        }
    }
}
