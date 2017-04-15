void setup() {
	Serial.begin(9600);
	delay(50);
}

void loop() {
	if (Serial.available())
		Serial.write(Serial.read()); // echo everything
}