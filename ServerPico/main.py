import network
import socket
import time
from machine import Pin
from wifi_config import SSID

# Configuración del LED
led = Pin("LED", Pin.OUT)

# Conectar a la red Wi-Fi
wlan = network.WLAN(network.STA_IF)
wlan.active(True)
wlan.connect(SSID)

print("Conectando a WiFi...")
while not wlan.isconnected():
    time.sleep(1)
print("Conectado a WiFi")

# Obtener la dirección IP
ip = wlan.ifconfig()[0]
print(f"Dirección IP: {ip}")

# Configurar el servidor web
addr = socket.getaddrinfo("0.0.0.0", 80)[0][-1]
s = socket.socket()
s.bind(addr)
s.listen(1)

print("Servidor web iniciado, esperando conexiones...")

# Función para manejar las solicitudes
def handle_request(client):
    request = client.recv(1024)
    request = str(request)
    print("Solicitud recibida:")
    print(request)
    
    led_on = "/?led=on" in request
    led_off = "/?led=off" in request

    if led_on:
        led.value(1)
    elif led_off:
        led.value(0)

    # Respuesta HTTP
    response = """\
HTTP/1.1 200 OK

<html>
    <head>
        <title>Control de LED</title>
    </head>
    <body>
        <h1>Control de LED</h1>
        <p>LED is {}.</p>
        <a href="/?led=on"><button>Encender</button></a>
        <a href="/?led=off"><button>Apagar</button></a>
    </body>
</html>
""".format("ON" if led.value() else "OFF")

    client.send(response)
    client.close()

# Bucle principal para aceptar conexiones
while True:
    client, addr = s.accept()
    print(f"Cliente conectado desde {addr}")
    handle_request(client)
