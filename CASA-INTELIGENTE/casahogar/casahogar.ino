#define sensorHumedad A0
#define sensorLuz A1
#define sensorPIR 5

int valorHumedad = 0;
int valorLuz = 0;
int valorPIR = 0;

unsigned long tiempoAnterior = 0;
const unsigned long intervalo = 1000; // cada 1 segundo

void setup() {
  Serial.begin(9600);

  // Pines de LEDs (6 a 13) como salida
  for (int pin = 6; pin <= 13; pin++) {
    pinMode(pin, OUTPUT);
  }

  // Pines de sensores
  pinMode(sensorPIR, INPUT); // PIR es digital
}

void loop() {
  unsigned long tiempoActual = millis();
  if (tiempoActual - tiempoAnterior >= intervalo) {
    tiempoAnterior = tiempoActual;

    // Leer humedad (0-100%)
    valorHumedad = map(analogRead(sensorHumedad), 0, 1023, 100, 0);
    Serial.print("Humedad:");
    Serial.print(valorHumedad);
    Serial.println("%");

    // Leer luz (0-100%)
    valorLuz = map(analogRead(sensorLuz), 0, 1023, 100, 0);
    Serial.print("Luz: ");
    Serial.print(valorLuz);
    Serial.println("%");

    // Leer PIR (0 o 1)
    valorPIR = digitalRead(sensorPIR);
    if (valorPIR == HIGH) {
      Serial.println("Movimiento:Detectado");
    } else {
      Serial.println("Movimiento:No detectado");
    }
  }

  // Control de LEDs por comandos seriales
  if (Serial.available() > 0) {
    char recibido = Serial.read();

    if (recibido == 'a') digitalWrite(13, HIGH);
    else if (recibido == 'b') digitalWrite(13, LOW);

    else if (recibido == 'c') digitalWrite(12, HIGH);
    else if (recibido == 'd') digitalWrite(12, LOW);

    else if (recibido == 'e') digitalWrite(11, HIGH);
    else if (recibido == 'f') digitalWrite(11, LOW);

    else if (recibido == 'g') digitalWrite(10, HIGH);
    else if (recibido == 'h') digitalWrite(10, LOW);

    else if (recibido == 'i') digitalWrite(9, HIGH);
    else if (recibido == 'j') digitalWrite(9, LOW);

    else if (recibido == 'k') digitalWrite(8, HIGH);
    else if (recibido == 'l') digitalWrite(8, LOW);

    else if (recibido == 'm') digitalWrite(7, HIGH);
    else if (recibido == 'n') digitalWrite(7, LOW);

    else if (recibido == 'o') digitalWrite(6, HIGH);
    else if (recibido == 'p') digitalWrite(6, LOW);

    else if (recibido == '1') {
      for (int pin = 6; pin <= 13; pin++) digitalWrite(pin, HIGH);
    }
    else if (recibido == '0') {
      for (int pin = 6; pin <= 13; pin++) digitalWrite(pin, LOW);
    }
  }
}