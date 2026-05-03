# Image Compression Application

# Getting Started
To use the Image Compression application extract the repo zip file and run the .exe that can be found at the executable directory if you get any antivirus popups click te option to run anyway (assuming that your antivirus has that option) and it should open with no problems whatsoever.

Otherwise to edit the program you will need to install the Visual Studio IDE, WinForms, Kyrpton.Toolkit package and Magick.net package once all of these have been intsalled you can double click the .sln to edit the application to your liking. 

# Documentation
The Colour Qunantization setting allows you to adjust the amount of colours you can represent in one pixel of an image to reduce the amount of distinct colours found in the image for example, if you set the Colour Quantization value to 2 you are giving 2 bits to the image to represent a total of 4 colours otherwise if it was 16 bits it would represent 65,536 colours. 

When it comes to dithering algorithms, there are two that come into mind FloydSteinberg and Riemersma. both algorthims attempt to solve the problem of colour banding caused by the lack of amount of colours a image can represent which is a common problem with GIF image types. FloydStienberg specifically tackles that problem by starting at the top left corner and move horizontally to the right until the bottom has been reached, spreading the quantization error found to the neighbouring pixels and creates dot patterns as a result in order to fill in the missing shades that are unavailable to fill in traditionally. 

Riemersmas approach is somewhat similar to the FloydSteinberg algorithm however, what it does instead is reduce a black and white or a coloured image to any palette meanwhile restricting the dithered pixel's effect to the surrounded area. Introducing a middleground on having both the benefits of ordered and error diffusion handling which gives the image a unique pattern that is more bold than the average FloydSteinberg pattern. Demonstrations of these algorithms can be found at the Image Demos section below. 

Chroma Subsampling is a technique used to reduce the detail in colours while trying to keep a majority of the brightness information needed to percieve the compressed image normally as you would with any other image you would see on the internet. It does this by taking advantage of the human eye being able to tell a bigger difference between brightness compared to colour differences. This is adjustable through a ratio split between 3 sections: Y (Luma) — brightness information, Cb — blue color difference and Cr — red color difference. Where Luma always remains at a constant value of 4 while the rest of the ratios are interchangable this application will make use of these common ratios which is at descending order of quality: 4:4:4, 4:2:2, 4:2:0 and 4:1:1.

There is no fixed aspect ratio like 16:9 or 4:3 as the magick.net library seems to make aspect ratios dynamically as far as im observing it which means, if you provide a width value of 1920 but the height value is set to 0 that new height value becomes 1818 to prevent the image from stretching. Lastly, WebP image previewing isnt available on the PictureBox tool and will be substituted with a exclamation mark error image icon otherwise all other image formats such as PNG, GIF, JPG and BMP will all have image previews.     

# Image Demos 

Orignal image (with no colour quantization) 
<img width="498" height="377" alt="ryu-ishigori-jjk" src="https://github.com/user-attachments/assets/e3001a94-c6d0-4269-a4f5-706d64f255f6" />

No Dithering applied (colour quantization set at 2 bits) 
<img width="498" height="377" alt="output564027" src="https://github.com/user-attachments/assets/667c6f11-0716-4b82-b2a7-94d6a81d8d4b" />

Riemersma applied (colour quantization set at 2 bits) 
<img width="498" height="377" alt="output2536264" src="https://github.com/user-attachments/assets/5fdeae2e-d187-4436-91ba-edf7a933dbee" />

FloydSteinberg applied (colour quantization set at 2 bits) 
<img width="498" height="377" alt="output241341" src="https://github.com/user-attachments/assets/6ec05bc3-9e97-4540-b1a0-dadd4eaf6ce8" />

No Chroma Subsampling applied 
<img width="640" height="400" alt="image" src="https://github.com/user-attachments/assets/ab065271-5807-4cb1-8493-f1d7f52e99b5" />

chroma subsampling 4:2:2 applied
<img width="640" height="400" alt="image" src="https://github.com/user-attachments/assets/3b2c55b5-762b-4501-a95f-ec2f5a0e299c" />

chroma subsampling 4:2:0 applied
<img width="640" height="400" alt="image" src="https://github.com/user-attachments/assets/17e58a3f-31d2-4905-a4aa-24b78a53d98f" />

chroma subsampling 4:1:1 applied 
<img width="640" height="400" alt="image" src="https://github.com/user-attachments/assets/93ead124-2971-471c-b962-958039a20a8c" />

(credits to red 101 website for the image comparisons on chroma subsampling) 
