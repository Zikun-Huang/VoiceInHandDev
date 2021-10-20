# VoiceInHand (Not Finished, Continue Working on)

This is a Repo for FY2022 Hackathon project, Dev team, CSS, Microsoft, and it's mainly for the mobile app version.

You may be able to access this site for more information:
https://garagehackbox.azurewebsites.net/hackathons/2356/projects/103552

## Description
### Overview
VocieInHand is a powerful & handy mobile application, used for two-way translation between voice and sign language, and Text is used as the middle translation format. 

With the mission to empower disability who are suffering hearing or speaking impairment to communicate easily with normal ones, VocieInHand also can enable people who want to communicate with disability without distance. We are delighted to achieve more and contribute more to the society with Microsoft's core value "Inclusive ".

### Background
Nowadays, the number of disabled people around the world is more than 1 billion amazingly, among which 85 million is in China. Have you ever imagined how they are able to see the doctor by themselves? 
![Background Stat 1](https://github.com/CassieJie/VIHPics/blob/main/Screenshot%202021-10-19%20152804.png?raw=true)


### Technical Architecture

As regards to the technical architecture, a frontend mobile app is developed using Xamarin for UI interface with end user. A backend app service is developed to interact with the core Azure Artificial Intelligence service, cutting video into slices and storing data of sign language movement and its corresponding verbal expression, building up a mathematical model.

In the sign language Artificial Intelligence model, we use images as the training dataset and prediction samples, creating training and prediction endpoint with the help of Azure vision service.
![Technical Architecture](https://github.com/Zikun-Huang/VoiceInHandDev/blob/master/MediaResources/images4ppt/image.png?raw=true)

### Challenges & Overcome
![Challenges & Overcome](https://github.com/CassieJie/VIHPics/blob/main/challenge.png?raw=true)

### Future & Outlook
1. In the future, we hope to integrate our application into Teams, people can open the real-time translation for sign-language to chat/meeting with the hearing-impaired person.
2. If we go further in the technical part, we can support different Sign languages to be interpreted. And we can support more different natural languages for different countries to use.
3. There's room to improve our sign-language interpretation model and make it more human-friendly in the future. 
![Future & Outlook](https://github.com/CassieJie/VIHPics/blob/main/future-1.png?raw=true)

## Story
### Inspireation
Recently, there is a heated discussion on WeiBo App about a disabled father who couldn’t help crying when bringing his daughter to the doctor.  As disabled himself, Mr.Wu’s biggest wish to his child is having a healthy body. He was quite concerned about not being able to communicate before seeing the doctor. When seeing Doc. Wang, Mr. Wu tried his best to write down a mixture of Chinese Character & Pinyin to describe his daughter’s status, with tears dropping non-stop.

![Inspiration](https://github.com/CassieJie/VIHPics/blob/main/story.png?raw=true)

### Front-End Mobile App Design 
Our VoiceInHand (for Android and iOS) is empowered by Xamarin, which is a powerful cross-platform development platform, especially for mobile apps. 
Check out some UI/UX design for our mobile version app. 

#### Talk as usual! [Main Features/Logics]
Translate Sign Languages and Languages in bi-direction way, which is powered by Azure Cognitive and Machine Learning. Besides, you can also save frequently used or favourite sets of translation results for quick review.  
![Design 1](https://github.com/CassieJie/VIHPics/blob/main/UI%20portable.png?raw=true)

#### Choose your language! [Localization] 
Just like us who speak different languages, we are also adding support for different sign languages to empower everyone communicating with each other without obstacles! 
![Design 2](https://github.com/CassieJie/VIHPics/blob/main/555.png?raw=true)

### Back-End Design
We developed a Back-End system with a web app to interact with SQL database and wrote a video analysing algorithm, and we preserved channels to interact with our Sign-language interpretation AI model to get sign language recognition results.

![Backend Design 1](https://github.com/CassieJie/VIHPics/blob/main/Back-end.png?raw=true)

### Sign-language interpretation model
We take photos of sign language gestures by ourselves as sampling data and then cut out these photos to training the Sign-language interpretation model with lots of marked labels. After input lots of training data, we put some test examples into the model and output the prediction result to the web app.

![Backend Design 2](https://github.com/CassieJie/VIHPics/blob/main/Model-3.png?raw=true)
