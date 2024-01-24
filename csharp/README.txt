Gilded Rose Tests
This repository has tests for the Gilded Rose code, ensuring the UpdateQuality method works for different items.

Tested Conditions:
Quality and Sell-in degrades once every day.

Quality drops faster after Sell-in reaches zero.

Quality is never negative.

Aged Brie Quality increases.

Quality is never more than 50.

Sulfuras never changes

Backstage Passes quality increases based on sell-in.
Increase by 2 When 10 Days or Less
Increase by 3 When 5 Days or Less
Quality drops to zero after the concert.

Challenges:
Figuring out the existing Gilded Rose logic.
Writing the unit tests

Testing Strategy:
We used NUnit testing framework to write the unit tests.
We used the AAA (Arrange, Act, Assert) pattern to structure the tests.	
We created unit tests for regular items and edge cases.

How to run:
Clone the repo.
Navigate to the test project.
Run tests using NUnit testing framework.