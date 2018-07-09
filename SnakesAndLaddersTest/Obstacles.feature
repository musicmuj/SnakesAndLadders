Feature: Obstacles
	In order to avoid silly mistakes
	As a game player
	I want to know which square I would be there if I encountered obstacles.

@obstacles_encountered
Scenario: Give the player the current square and how many steps will move on.
	Given Player current square is 0
	And he/she is going to move 2 steps
	When he/she moved
	Then he/she should encounter obstacle and he/she would be square 38
