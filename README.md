# matchupquiz
Shameless Mathcounts-style CDR program, built for VCSMS’s math department.

### Description

Our math department conducts a matchup-styled quiz bee for junior high students. Each round consists of several forty-five second questions. The first player to buzz in with a correct answer gets the points. If this sounds familiar, [you’re probably right](https://en.wikipedia.org/wiki/Mathcounts#Countdown_Round) – but *sssshhh*.

This is a small program for conducting these rounds. The system this program is run on has a slideshow of the problems. At the beginning of each question, the program changes the slide and starts the timer, waiting for either player to buzz in their answer. When a player buzzes and gets the correct answer, they score a point, and play continues. Otherwise, the other player has the remaining time.

The program keeps track of points and determines the winner, the player with most points after a set number of questions. If scores are tied, the round becomes sudden-death: the first person to answer correctly wins the round. (Some formats declare winners when a player reaches a set number of points; this will be implemented in a later release.)

### Installation
Install (if you don’t have already) [.NET 4.5](https://www.microsoft.com/en-ph/download/details.aspx?id=30653) or compatible framework. Then:
- Run application found in [bin/release](matchupquiz/bin/Release/matchupquiz.exe). It’s standalone – it doesn’t depend on any other files.
- Alternatively, run installer found in [publish](https://github.com/cjquines/matchupquiz/tree/master/publish).

### Usage

![Settings screen](http://i.imgur.com/ppbmhJG.png)

1. Drag the crosshairs to the window of the slideshow. This can be a PowerPoint presentation or a PDF viewer.
2. Change the player names in the text box.
3. Change the time (in seconds) per question and the number of questions per round.
4. Set which keys are used by the players to buzz in.
    - Keys 1 refers to player 1’s keys. If any of these keys are pressed, player 1 is considered to have buzzed.
    - Similarly, keys 2 refers to player 2’s keys.
5. Change the colors of the program by clicking on each rectangle.
6. Press the start button to start the program.

![Main program](http://i.imgur.com/7F4BSoD.png)

The screen consists of the timer in center, with the status below the timer. The status begins with “Round start”, indicating the start of the round. When the timer is paused, you can
- click either player’s name to change it, or
- click the status to bring up the settings screen.

At the beginning of a round:
1. Clicking the timer starts the question:
    - The program switches to the slideshow and presses the right arrow key (which should change the slide).
    - Then it switches back to the program and starts the timer. The status “Question X” is shown for the Xth question.
2. When the timer is ticking, and **either** player presses any of their keys, the timer stops and that player’s score turns yellow:
    - Clicking the timer marks their answer as wrong. Their score turns gray, and it moves to step 3.
    - Clicking the player’s score marks their answer as correct. The question ends, moving to step 4.
3. If the first player to guess gets a wrong answer, the timer starts again. When the **other** player presses any of their keys, the timer stops and that player’s score turns yellow:
    - Clicking the timer marks their answer as wrong.
    - Clicking the player’s score marks their answer as correct.
In either case, the question ends, moving to step 4.
4. At the end of a question, if neither player has won, a status indicating what happened is shown. The program returns to step 1.
5. If a player has won, then the round ends. Clicking the timer resets the scores and returns to step 1.

### Setup

Various setups are possible. Here’s the setup we plan to use:

![I have superb illustration skills.](http://i.imgur.com/l5I734r.png)

The program relies on only one system, which has four outputs: the problem projected to the audience, two monitors for either player, one monitor for the program. Either player has a buzzer (we plan to get a numpad, mutilate it and cover it with a piece of cardboard; thus multiple keys for each player), connected to the system. This has the advantage of the players being able to face the audience, and requiring only one system.
