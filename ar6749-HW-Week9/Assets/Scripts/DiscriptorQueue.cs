using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class DiscriptorQueue : MonoBehaviour
{
    //create queue for poetry lines
    private Queue<string> lineQueue = new Queue<string>();
    
        //grab canvas text
        public Text display;
    
        //create 5 second timer for when name can be entered
        private float timer = 0;
        private float targetTime = 5;
        
        private void Update()
        {
            // press space to reload scene and start over 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
            // if targetTime is reached, continue
            if (timer > targetTime) return;
            
            // increase timer with game-time
            timer += Time.deltaTime;
    
            // if letter is pressed, enqueue letter-specific line
            if (Input.GetKeyDown(KeyCode.A))
            {
                lineQueue.Enqueue("Cocky");
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                lineQueue.Enqueue("Sexy");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                lineQueue.Enqueue("Slimy");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                lineQueue.Enqueue("Arrogant");
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                lineQueue.Enqueue("Confused");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                lineQueue.Enqueue("Sweet-Talker");
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                lineQueue.Enqueue("Stubborn");
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                lineQueue.Enqueue("Merciful");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                lineQueue.Enqueue("Creepy");
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                lineQueue.Enqueue("Cynical");
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                lineQueue.Enqueue("Idiotic");
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                lineQueue.Enqueue("Inspiring");
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                lineQueue.Enqueue("Helpful");
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                lineQueue.Enqueue("Gloomy");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                lineQueue.Enqueue("Playful");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                lineQueue.Enqueue("Popular");
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                lineQueue.Enqueue("Warm");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                lineQueue.Enqueue("Unpredictable");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                lineQueue.Enqueue("Beautiful"); 
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                lineQueue.Enqueue("Tranquil");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                lineQueue.Enqueue("Talented");
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                lineQueue.Enqueue("Sassy");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                lineQueue.Enqueue("Sophisticated");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                lineQueue.Enqueue("Stern");
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                lineQueue.Enqueue("Strong");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                lineQueue.Enqueue("Respectful");
            } 
            
            // if time runs out, change display text and run ShowDescriptors function
            if (timer >= targetTime)
            {
                display.text = "Your descriptors: \n";
    
                ShowDescriptors();
            }
            else
            {
                // otherwise, display shorter version of countdown
                display.text = "Write your name and find out what people think of you:  Timer: " + 
                               (targetTime - timer).ToString("F1");
            }
        }
    
        //function to display dequeued lines when timer runs out
        private void ShowDescriptors()
        {
            while (lineQueue.Count > 0)
                display.text += "\n" + lineQueue.Dequeue();
        }
}