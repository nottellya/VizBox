Hi :)

Thanks to bought this asset :) I hope you like it?

Check my others products and contacts informations to :
https://www.assetstore.unity3d.com/en/#!/publisher/9029/page=1/sortby=popularity

And please, take just one minute of your time to post a 
review/stars on the store it's really important for publishers...

About the rendering : 

To get the same as the video, install the package post processing via the package manager :

Define your build project to LINEAR and DEFFERED RENDERING.

Do not hesitate to try the SCREEN SPACE REFLEXION (In this case you need to deactivate all reflexions probes)

Regards


-------------------------------------------------------------------------------------
Here are a series of questions and answers about the kit (I love talking to myself) :
-------------------------------------------------------------------------------------

---------------------------------------------------------------------
"Hell! I compute lightmap but my rendering is black or/and glitched?"
---------------------------------------------------------------------

- Don't panic, it's a unity problem with lightmap, to fix it : Clear the GI cache first, and next delete the 
  directory called "Example_01" and recompute lightmap.


---------------------------------------
"Those damned doors did not open? Why?"
---------------------------------------

- Keep calm :) Do not write a crappy review now :) The problem due to the static mode! Unity do not want move 
  objects flagged as static… You just have to search the gameobjects names "Door_B » and "Door_A », select
  them all and flag them static before lightmap

  I can not tell you the number of times, after two hours of lightmap computing, i realized that the doors were 
  in static = off...)
