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

@obstacles_encountered_snakes
Scenario Outline: [Snakes] Give the player the current square and how many steps will move on.
	Given Player current square is <currentSquare>
	And he/she is going to move <steps> steps
	When he/she moved
	Then he/she should encounter obstacle and he/she would be square <resultSquare>
Examples: 
| currentSquare | steps | resultSquare |
| 92            | 7     | 80           |
| 80            | 15    | 75           |
| 75            | 17    | 88           |
| 88            | 1     | 68           |
| 68            | 6     | 53           |
| 53            | 11    | 60           |
| 60            | 2     | 19           |
| 19            | 30    | 11           |
| 11            | 35    | 25           |
| 10            | 6     | 6            |

@obstacles_encountered_ladders
Scenario Outline: [Ladders] Give the player the current square and how many steps will move on.
	Given Player current square is <currentSquare>
	And he/she is going to move <steps> steps
	When he/she moved
	Then he/she should encounter obstacle and he/she would be square <resultSquare>
Examples: 
| currentSquare | steps | resultSquare |
| 0             | 2     | 38           |
| 2             | 5     | 14           |
| 5             | 3     | 31           |
| 8             | 7     | 26           |
| 15            | 6     | 42           |
| 21            | 7     | 84           |
| 28            | 8     | 44           |
| 36            | 15    | 67           |
| 51            | 20    | 91           |
| 71            | 7     | 98           |
| 78            | 9     | 94           |