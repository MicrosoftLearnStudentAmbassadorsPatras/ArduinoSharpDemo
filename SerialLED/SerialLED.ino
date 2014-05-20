int led = 13;
int incomingByte = 0;	// for incoming serial data

void setup() {
  pinMode(led, OUTPUT);     
  Serial.begin(9600);	// opens serial port, sets data rate to 9600 bps
}

void loop() {
  if (Serial.available() > 0) {
    incomingByte = Serial.read();
    
    if(incomingByte==49){
      digitalWrite(led, HIGH);
    }
    else{
      digitalWrite(led, LOW); 
    }
  }
}

