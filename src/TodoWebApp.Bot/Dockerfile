FROM python:3.11-slim
WORKDIR /TodoWebApp.Bot
COPY requirements.txt .
RUN pip install -r /TodoWebApp.Bot/requirements.txt
COPY . .
CMD [ "python3", "main.py" ]