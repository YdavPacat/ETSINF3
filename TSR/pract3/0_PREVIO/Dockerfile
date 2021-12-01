FROM ubuntu:focal
RUN apt-get update -y
RUN apt-get install -y curl ufw gcc g++ make gnupg
#RUN curl -sL https://dl.yarnpkg.com/debian/pubkey.gpg | apt-key add -
#RUN echo "deb https://dl.yarnpkg.com/debian/ stable main" | tee /etc/apt/sources.list.d/yarn.list
#RUN apt-get install -y yarn
RUN curl -sL https://deb.nodesource.com/setup_14.x | bash -
RUN apt-get update -y
RUN apt-get install -y nodejs
#RUN apt-get install -y nodejs npm
RUN apt-get upgrade -y
RUN npm init -y
RUN npm install zeromq@5
#RUN npm install -g zeromq@5
#RUN ufw allow 8000:9999/tcp
