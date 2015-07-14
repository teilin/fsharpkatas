#FSharp Katas
In this repostory I just playing around with katas doing F# on my mac. Getting used to coding F#
on a mac and get more familiar with functional progamming using F#.

##Requirements
To be able to use F# on a mac, it is required to have mono and fsharp installed. I followed the
option 3 on the [fsharp.org](http://fsharp.org/use/mac/) page. So I installed the mono 64 bit
version.

Then I added the `/mono64/bin`to the PATH by typing this in the terminal:

	cd
	nano .bash_profiles
	
Then I added one line to the top of this file:

	export "/mono64/bin:$PATH"
	
When this is done, I had to log out of the computer and log in again. I tryed to just exit the
terminal and start it again, but my path did not take the changes then. To see if the
changes is done, check the path: `echo $PATH` 

##Compile and run
To compile and run the program with the terminal on OSX.

	fsharpc *.fs
	mono KatasMain.exe