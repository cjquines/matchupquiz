# matchupquiz
A Mathcounts-style quiz program for Windows. Keeps track of scores and times. Switches slides automatically.

### Description

Our math department conducts a matchup-styled quiz bee for junior high students. Each round consists of several forty-five second questions. The first player to buzz in with a correct answer gets the points. If this sounds familiar, [you’re probably right](https://en.wikipedia.org/wiki/Mathcounts#Countdown_Round) – but *sssshhh*.

This is a small program for conducting these rounds. The system this program is run on has a slideshow of the problems. At the beginning of each question, the program changes the slide and starts the timer, waiting for either player to buzz in their answer. When a player buzzes and gets the correct answer, they score a point, and play continues. Otherwise, the other player has the remaining time.

The program keeps track of points and determines the winner, the player with most points after a set number of questions. If scores are tied, the round becomes sudden-death: the first person to answer correctly wins the round. (Some formats declare winners when a player reaches a set number of points; this will be implemented in a later release.)

### Installation
Install (if you don’t have already) [.NET 4.5](https://www.microsoft.com/en-ph/download/details.aspx?id=30653) or compatible framework. Then download and run [matchupquiz.exe](https://github.com/cjquines/matchupquiz/releases/download/v1.0.0/matchupquiz.exe). 

### Usage

![Settings screen](http://i.imgur.com/ppbmhJG.png)

1. Open your slideshow. The first slide can be anything. Each next slide must contain a single question.
2. Drag the crosshairs to the window of the slideshow.
3. Change the player names in the text box.
4. Change the time (in seconds) per question and the number of questions per round.
5. Set which keys are used by the players to buzz in.
    - Keys 1 refers to player 1’s keys. If any of these keys are pressed, player 1 is considered to have buzzed. (So for example, player 1 can have multiple buzzer keys that they can press, whichever is most comfortable)
    - Similarly, keys 2 refers to player 2’s keys.
6. Change the colors of the program by clicking on each rectangle.
7. Press the start button to start the program.

![Main program](http://i.imgur.com/7F4BSoD.png)

When the main screen is shown:
1. Click the timer to start the next question.
2. When the timer is ticking, players can buzz in by pressing their buttons.
    - If the player is wrong, click the timer. The other player has a chance to buzz in.
    - If the player is right, click their score. Return to step 1.
3. If both players are wrong, return to step 1.
4. If a player has won, the round ends. Click the timer to reset scores and return to step 1.

Some notes:
- When the timer is paused, you can click either player’s name to change it.
- When the timer is paused, you can click the status to bring up the setting screen. The status is the phrase below the timer.
- When clicking the timer in step 1, the program switches to the slide show and presses the right arrow key. The right arrow key is used to change the slide. 
- A yellow score indicates that the player is currently answering. A gray score indicates they do not have a chance to guess.
- At the end of a question, if a player has won, the round ends. Clicking the timer resets the scores and returns to step 1.

### Setup

Various setups are possible. Here’s the setup we use:

![I have superb illustration skills.](http://i.imgur.com/l5I734r.png)

The program relies on only one system, which has four outputs: the problem projected to the audience, two monitors for either player, one monitor for the program. Either player has a buzzer (we use a numpad, with some keys removed, covered with a piece of cardboard; thus multiple keys for each player), connected to the system. This has the advantage of the players being able to face the audience, and requiring only one system.
