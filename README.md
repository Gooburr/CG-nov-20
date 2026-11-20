# CG nov 20
\
Shader 1:\
\
The first shader that we added to this project is a shader for the lava. This does two separate things for whatever it's applied to. It's UV scrolls using an offset node which simulates the flowing of the lava. The second feature is emissive lighting that has it's own colour that can be adjusted in the materials panel, this was added because lava emits light so we figured it'd look nice to have the lava glow as well.\
<img width="887" height="446" alt="Screenshot 2026-11-20 180027" src="https://github.com/user-attachments/assets/683f98a5-95d3-47b6-8628-82e8539fc782" />\
<img width="482" height="207" alt="Screenshot 2026-11-20 175655" src="https://github.com/user-attachments/assets/ca3d3d0d-e597-4099-beb8-d0501a8a91b5" />\
Pictured above is the shadergraph alongside the materials custom values that were applied to it. I thought combining an emissive and offset shader together would be fitting for the lava below the player as lava is known to move around and glow (I'm sorry if that's a patronizing explanation I could not think of a way of explaining this that didn't make it seem like I was explaining it to a toddler).\
\
Shader 2:\
\
The second shader that we added to this project is a shader for Bowser. This shader has a branch node that allows it to switch between two colours. Using this we were able to do some programming that changes the value of the float in the shader graph when Bowser touches the lava.\
<img width="894" height="549" alt="Screenshot 2026-11-20 180306" src="https://github.com/user-attachments/assets/bcaf8bf0-951b-40a8-adea-e6a234e06e10" />\
<img width="473" height="91" alt="Screenshot 2026-11-20 180331" src="https://github.com/user-attachments/assets/58dee10a-9ac8-439a-973a-6ddde72d6c30" />\
<img width="1043" height="602" alt="Screenshot 2026-11-20 180355" src="https://github.com/user-attachments/assets/c84b5de2-391b-48bf-84b8-af795482e250" />\
Pictured above is the shadergraph, the materials custom values and the coding done in C#. Upon Bowser coming into contact with a game object with the tag "Lava" the script finds the float value in a predetermined material and sets it to 1. Once the game is launched the script sets the float value to 0 so that it resets back to the default colour. The colours chosen are meant to emulate Bowser's main yellow colour and the greyish white colour of Bowser's skeleton form.\
