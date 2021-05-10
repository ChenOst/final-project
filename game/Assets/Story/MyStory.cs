﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: MyStory.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @MyStory: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("confrontTheMayor", () => this.@confrontTheMayor, val => this.@confrontTheMayor = val);
			VarDef("mission1Complete", () => this.@mission1Complete, val => this.@mission1Complete = val);
			VarDef("mission2Complete", () => this.@mission2Complete, val => this.@mission2Complete = val);
			VarDef("enemyTheMayor", () => this.@enemyTheMayor, val => this.@enemyTheMayor = val);
			VarDef("mission5Complete", () => this.@mission5Complete, val => this.@mission5Complete = val);
			VarDef("mission3Complete", () => this.@mission3Complete, val => this.@mission3Complete = val);
			VarDef("mission3Started", () => this.@mission3Started, val => this.@mission3Started = val);
			VarDef("mission4Complete", () => this.@mission4Complete, val => this.@mission4Complete = val);
		}

		public StoryVar @confrontTheMayor;
		public StoryVar @mission1Complete;
		public StoryVar @mission2Complete;
		public StoryVar @enemyTheMayor;
		public StoryVar @mission5Complete;
		public StoryVar @mission3Complete;
		public StoryVar @mission3Started;
		public StoryVar @mission4Complete;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@MyStory()
	{
		this.StartPassage = "Claudelius";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Claudelius

	void passage1_Init()
	{
		this.Passages[@"Claudelius"] = new StoryPassage(@"Claudelius", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Hello old friend!");
		yield return lineBreak();
		yield return text("Thanks for coming to help.");
		yield return lineBreak();
		yield return text("My friend Alf went missing and the people in the town started to act strange... ");
		Vars.confrontTheMayor  = false;
		yield return lineBreak();
		yield return link("Who is acting strange? ", "Strange People", null);
		yield return lineBreak();
		yield return link("Tell me about Alf ", "About Alf", null);
		yield return lineBreak();
		yield return link("Do you have a direction to start with? ", "First Mission Intro", null);
		yield break;
	}


	// .............
	// #2: Strange People

	void passage2_Init()
	{
		this.Passages[@"Strange People"] = new StoryPassage(@"Strange People", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("I don't want to start with accusations...");
		yield return lineBreak();
		yield return link("Tell me about Alf ", "About Alf", null);
		yield return lineBreak();
		yield return link("Ok I'm ready to start ", "First Mission Intro", null);
		yield break;
	}


	// .............
	// #3: First Mission Intro

	void passage3_Init()
	{
		this.Passages[@"First Mission Intro"] = new StoryPassage(@"First Mission Intro", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("I was looking at Alfs' house and discover a weird passage in his basement.");
		yield return lineBreak();
		yield return text("When I went in I discover a whole underground area.");
		yield return lineBreak();
		yield return text("The shpae... it looked familiar I... I search In the books and found what it means.");
		yield return lineBreak();
		yield return link("Tell me more ", "BSP Rooms And RPC", null);
		yield break;
	}


	// .............
	// #4: About Alf

	void passage4_Init()
	{
		this.Passages[@"About Alf"] = new StoryPassage(@"About Alf", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Alf is the chef of the town and a good friend of mine.");
		yield return lineBreak();
		yield return text("After he didn't open his shop in the morning I went to look for him but couldn't find him anywhere.");
		yield return lineBreak();
		yield return link("Are there any suspects? ", "Strange People", null);
		yield return lineBreak();
		yield return link("Ok I'm ready to start ", "First Mission Intro", null);
		yield break;
	}


	// .............
	// #5: BSP Rooms And RPC

	void passage5_Init()
	{
		this.Passages[@"BSP Rooms And RPC"] = new StoryPassage(@"BSP Rooms And RPC", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("It looks like Binary Space Partitioning for rooms with Random Point Connect.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission1", null);
		yield return lineBreak();
		yield return link("Random Point Connect? ", "RPC1", null);
		yield return lineBreak();
		Vars.mission1Complete  = false;
		yield break;
	}


	// .............
	// #6: BSP Rooms mission1

	void passage6_Init()
	{
		this.Passages[@"BSP Rooms mission1"] = new StoryPassage(@"BSP Rooms mission1", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("It Works by dividing the map into a series of rectangles, and then placing a room in each one on the map. The rectangle can be split either vertically or horizontally, and the minimum size of the split is determined based on the minimum size of the rooms.");
		yield return lineBreak();
		yield return link("Random Point Connect? ", "RPC1", null);
		yield return lineBreak();
		yield return link("Ok I'm raedy ", "First Mission", null);
		yield break;
	}


	// .............
	// #7: RPC1

	void passage7_Init()
	{
		this.Passages[@"RPC1"] = new StoryPassage(@"RPC1", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("Algorithm that works by first iterating through the list of rooms created by the room generation algorithm.  For each corridor it draws, it selects a random point at the edge of each of the rooms and connects. If the points are parallel, the algorithm will draw a straight corridor in the appropriate vertical or horizontal direction. If the points are not parallel, the algorithm will draw a forked corridor made up of three straight corridors in order to connect the points.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission1", null);
		yield return lineBreak();
		yield return link("Ok I'm raedy ", "First Mission", null);
		yield break;
	}


	// .............
	// #8: First Mission

	void passage8_Init()
	{
		this.Passages[@"First Mission"] = new StoryPassage(@"First Mission", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("Go to Alf's house right here behind the mayor's back.");
		yield return lineBreak();
		yield return text("Search for Alf and return with more details...");
		yield return lineBreak();
		if(Vars.mission1Complete == true) {
			yield return lineBreak();
			yield return link("I found Alf... ", "Mission 1 Completed", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #9: Mission 1 Completed

	void passage9_Init()
	{
		this.Passages[@"Mission 1 Completed"] = new StoryPassage(@"Mission 1 Completed", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("Ohh no!");
		yield return lineBreak();
		yield return text("I'm so sad to heat that.. I wanted to belive he will be ok.");
		yield return lineBreak();
		yield return text("While you were gone I discovered that the problem is bigger then I thought, all the town is built on an undergroung tombs.");
		yield return lineBreak();
		yield return text("When I entered my basment I discover a hole like at Alfs house.");
		yield return lineBreak();
		yield return text("The shpae was built by Binary Space Partitioning for Rooms and Binary Space Partitioning for Corridors.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission2", null);
		yield return lineBreak();
		yield return link("Binary Space Partitioning for corridors? ", "BSP Corridors mission2", null);
		yield return lineBreak();
		Vars.mission2Complete  = false;
		yield break;
	}


	// .............
	// #10: The Mayor

	void passage10_Init()
	{
		this.Passages[@"The Mayor"] = new StoryPassage(@"The Mayor", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("Hello traveler!");
		yield return lineBreak();
		yield return text("My name is Granny Iga and I'm the mayor of this beautiful town.");
		yield return lineBreak();
		if(Vars.confrontTheMayor == true) {
			yield return lineBreak();
			yield return link("I know the truth about you! ", "Mayor Exposed", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #11: Mayor Exposed

	void passage11_Init()
	{
		this.Passages[@"Mayor Exposed"] = new StoryPassage(@"Mayor Exposed", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("You are smarter then i thought!");
		yield return lineBreak();
		yield return text("Now I will kill you!");
		yield return lineBreak();
		Vars.enemyTheMayor  = true;
		yield return lineBreak();
		Vars.mission5Complete  = false;
		yield break;
	}


	// .............
	// #12: BSP Rooms mission2

	void passage12_Init()
	{
		this.Passages[@"BSP Rooms mission2"] = new StoryPassage(@"BSP Rooms mission2", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("It Works by dividing the map into a series of rectangles, and then placing a room in each one on the map. The rectangle can be split either vertically or horizontally, and the minimum size of the split is determined based on the minimum size of the rooms.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for corridors? ", "BSP Corridors mission2", null);
		yield return lineBreak();
		yield return link("Ok I'm raedy ", "Second Mission", null);
		yield break;
	}


	// .............
	// #13: BSP Corridors mission2

	void passage13_Init()
	{
		this.Passages[@"BSP Corridors mission2"] = new StoryPassage(@"BSP Corridors mission2", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("Using the tree structure used by BSP Rooms algorithm. It sorts through the sub leaves, connecting each bottom leaf to its partner that shares a parent. When all sub leafs are paired in connects one out of each pair to another pair, until all sub-leafs containing rooms are connected.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission2", null);
		yield return lineBreak();
		yield return link("Ok I'm raedy ", "Second Mission", null);
		yield break;
	}


	// .............
	// #14: Second Mission

	void passage14_Init()
	{
		this.Passages[@"Second Mission"] = new StoryPassage(@"Second Mission", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("Go to my house to my on your right.");
		yield return lineBreak();
		yield return text("Explore the tomb and return with more information.");
		yield return lineBreak();
		if(Vars.mission2Complete == true) {
			yield return lineBreak();
			yield return link("I found an open coffin... ", "Mission 2 Completed", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #15: Mission 2 Completed

	void passage15_Init()
	{
		this.Passages[@"Mission 2 Completed"] = new StoryPassage(@"Mission 2 Completed", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("What? an open coffin? this is worst then I thought.");
		yield return lineBreak();
		yield return text("While you were gone Everett said she was attacked in her house.");
		yield return lineBreak();
		yield return link("Tell me more ", "Third Mission", null);
		yield return lineBreak();
		Vars.mission3Complete  = false;
		yield break;
	}


	// .............
	// #16: Everett

	void passage16_Init()
	{
		this.Passages[@"Everett"] = new StoryPassage(@"Everett", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("Hi nice to meet you!");
		yield return lineBreak();
		yield return text("I'm Everett.");
		yield return lineBreak();
		if(Vars.mission3Started == false) {
			yield return lineBreak();
			yield return text("Thank god you are here!");
			yield return lineBreak();
			yield return text("The Skeletons came and attack me in the middle of the night.");
			yield return lineBreak();
			yield return text("They hold a big book, I think you should search it out, it looked dangerous.");
			yield return lineBreak();
		}
		yield return lineBreak();
		if(Vars.mission3Complete == true) {
			yield return lineBreak();
			yield return text("Thanks for the help!");
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #17: BSP Rooms mission3

	void passage17_Init()
	{
		this.Passages[@"BSP Rooms mission3"] = new StoryPassage(@"BSP Rooms mission3", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("It Works by dividing the map into a series of rectangles, and then placing a room in each one on the map. The rectangle can be split either vertically or horizontally, and the minimum size of the split is determined based on the minimum size of the rooms.");
		yield return lineBreak();
		yield return link("Drunkard’s Walk? ", "DW mission3", null);
		yield return lineBreak();
		yield return link("Ok I'm ready ", "Mission 3 Completed", null);
		yield break;
	}


	// .............
	// #18: DW mission3

	void passage18_Init()
	{
		this.Passages[@"DW mission3"] = new StoryPassage(@"DW mission3", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return text("Similar to RPC it also selects vertex between the rooms and starts drawing a line the first vertex incrementing a randomly chosen amount of vertices in the direction of the second, When the corridor is being made by DW, the algorithm do it in “steps”. Each step adds a corridor of a random length that goes in the direction of the end point.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission3", null);
		yield return lineBreak();
		yield return link("Ok I'm ready ", "Mission 3 Completed", null);
		yield break;
	}


	// .............
	// #19: Mission 3 Completed

	void passage19_Init()
	{
		this.Passages[@"Mission 3 Completed"] = new StoryPassage(@"Mission 3 Completed", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		if(Vars.mission3Complete == false) {
			yield return lineBreak();
			yield return text("Go and help Everett.");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("I saw you got the book of the \"Algorithm Magic\", it used to belong to a very powerful witch a long time ago. I think she was waking from the coffin you found at my house.");
			yield return lineBreak();
			yield return link("I'm Ready for my next mission ", "Firth Mission", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #20: Third Mission

	void passage20_Init()
	{
		this.Passages[@"Third Mission"] = new StoryPassage(@"Third Mission", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield return text("After the calculations I did I think the next template that will appear is");
		yield return lineBreak();
		yield return text("Binary Space Partitioning for rooms and Drunkard’s Walk.");
		yield return lineBreak();
		yield return text("Go check this out.");
		yield return lineBreak();
		yield return link("Binary Space Partitioning for rooms? ", "BSP Rooms mission3", null);
		yield return lineBreak();
		yield return link("Drunkard’s Walk? ", "DW mission3", null);
		yield return lineBreak();
		Vars.mission3Started  = false;
		yield break;
	}


	// .............
	// #21: Firth Mission

	void passage21_Init()
	{
		this.Passages[@"Firth Mission"] = new StoryPassage(@"Firth Mission", new string[]{  }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		yield return text("While you were gone I went to Irvin house, I saw a huge skeleton walking around. I check in my books, this tomb is build with Random Room Placement and Random Point Connect.");
		yield return lineBreak();
		yield return link("Random Room Placement ? ", "RRP4", null);
		yield return lineBreak();
		yield return link("Random Point Connect? ", "RPC4", null);
		yield return lineBreak();
		Vars.mission4Complete  = false;
		yield break;
	}


	// .............
	// #22: RRP4

	void passage22_Init()
	{
		this.Passages[@"RRP4"] = new StoryPassage(@"RRP4", new string[]{  }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		yield return text("Algorithms that starts by randomly generating a room of a random width and length, the randomness of the size of the room is controlled by maximum and minimum allowed lengths.");
		yield return lineBreak();
		yield return link("Random Point Connect? ", "RPC4", null);
		yield return lineBreak();
		yield return link("Ok I'm ready ", "Mission 4 Completed", null);
		yield break;
	}


	// .............
	// #23: RPC4

	void passage23_Init()
	{
		this.Passages[@"RPC4"] = new StoryPassage(@"RPC4", new string[]{  }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		yield return text("Algorithm that works by first iterating through the list of rooms created by the room generation algorithm.  For each corridor it draws, it selects a random point at the edge of each of the rooms and connects. If the points are parallel, the algorithm will draw a straight corridor in the appropriate vertical or horizontal direction. If the points are not parallel, the algorithm will draw a forked corridor made up of three straight corridors in order to connect the points.");
		yield return lineBreak();
		yield return link("Random Room Placement ? ", "RRP4", null);
		yield return lineBreak();
		yield return link("Ok I'm ready ", "Mission 4 Completed", null);
		yield break;
	}


	// .............
	// #24: Mission 4 Completed

	void passage24_Init()
	{
		this.Passages[@"Mission 4 Completed"] = new StoryPassage(@"Mission 4 Completed", new string[]{  }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		if(Vars.mission4Complete == false) {
			yield return lineBreak();
			yield return text("Find and kill the skeleton at Irvin house.");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("Good job!");
			yield return lineBreak();
			yield return text("Now theres only one thing left to do.");
			yield return lineBreak();
			yield return text("I think the witch has strike now because she gain power over years.");
			yield return lineBreak();
			yield return link("Do you know who is the witch? ", "Fifth Mission", null);
			yield return lineBreak();
		}
		yield return lineBreak();
		yield break;
	}


	// .............
	// #25: Fifth Mission

	void passage25_Init()
	{
		this.Passages[@"Fifth Mission"] = new StoryPassage(@"Fifth Mission", new string[]{  }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return text("I think the mayor is the evil witch!");
		yield return lineBreak();
		yield return text("Talk to her and confront her!");
		yield return lineBreak();
		if(Vars.enemyTheMayor == true) {
			yield return lineBreak();
			yield return link("The mayor is gone!", "Mission 5", null);
			yield return lineBreak();
		}
		yield return lineBreak();
		Vars.confrontTheMayor  = true;
		yield break;
	}


	// .............
	// #26: End Game

	void passage26_Init()
	{
		this.Passages[@"End Game"] = new StoryPassage(@"End Game", new string[]{  }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		yield return text("Good job! you saved us!");
		yield return lineBreak();
		yield return text("I wish Alf was here...");
		yield break;
	}


	// .............
	// #27: Irvin

	void passage27_Init()
	{
		this.Passages[@"Irvin"] = new StoryPassage(@"Irvin", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		yield return text("Hi I'm Irvin.");
		yield return lineBreak();
		yield return text("I live here on you'r right.");
		yield break;
	}


	// .............
	// #28: Mission 5

	void passage28_Init()
	{
		this.Passages[@"Mission 5"] = new StoryPassage(@"Mission 5", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		yield return text("Go and search the mayor at her house!");
		yield return lineBreak();
		yield return text("It the last house in the town.");
		yield return lineBreak();
		yield return text("The tomb at her house is build with Random Room Placement and Drunkard’s Walk.");
		yield return lineBreak();
		yield return text("Go and kill the mayor.");
		yield return lineBreak();
		yield return link("Random Room Placement ? ", "RRP5", null);
		yield return lineBreak();
		yield return link("Drunkard’s Walk? ", "DW mission5", null);
		yield return lineBreak();
		if(Vars.enemyTheMayor == true) {
			yield return lineBreak();
			yield return link("I killed the mayor!", "End Game", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #29: RRP5

	void passage29_Init()
	{
		this.Passages[@"RRP5"] = new StoryPassage(@"RRP5", new string[]{  }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		yield return text("Algorithms that starts by randomly generating a room of a random width and length, the randomness of the size of the room is controlled by maximum and minimum allowed lengths.");
		yield return lineBreak();
		yield return link("Drunkard’s Walk? ", "DW mission5", null);
		yield return lineBreak();
		if(Vars.enemyTheMayor == true) {
			yield return lineBreak();
			yield return link("I killed the mayor!", "End Game", null);
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #30: DW mission5

	void passage30_Init()
	{
		this.Passages[@"DW mission5"] = new StoryPassage(@"DW mission5", new string[]{  }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		yield return text("Similar to RPC it also selects vertex between the rooms and starts drawing a line the first vertex incrementing a randomly chosen amount of vertices in the direction of the second, When the corridor is being made by DW, the algorithm do it in “steps”. Each step adds a corridor of a random length that goes in the direction of the end point.");
		yield return lineBreak();
		yield return link("Random Room Placement ? ", "RRP5", null);
		yield return lineBreak();
		if(Vars.enemyTheMayor == true) {
			yield return lineBreak();
			yield return link("I killed the mayor!", "End Game", null);
			yield return lineBreak();
		}
		yield break;
	}


}