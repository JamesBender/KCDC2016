Feature: TicTacToeGameEngine
	In order to determine the outcome of a tic tac toe game
	as the tic tac toe game engine
	I want to evalute to see happened

Scenario: When I have an empty board then there should be no winner
	Given I have a tic tac toe board
	And the board is empty
	When I determine the outcome
	Then the the result should be a stalemate

Scenario: When X is in all the row then X wins
	Given I have a tic tac toe board
	And the top row is all "X"
	When I determine the outcome
	Then the result is "X" is the winner

Scenario: When O is in all the row then O wins
	Given I have a tic tac toe board
	And the top row is all "O"
	When I determine the outcome
	Then the result is "O" is the winner

Scenario: When I have board that looks like this
	Given I have a tic tac toe board
	And the board looks like this
		| col1 | col2 | col3 |
		| X    | O    |      |
		| O    | X    | O    |
		|      |      | X    |
		When I determine the outcome
		Then the result is "X" is the winner