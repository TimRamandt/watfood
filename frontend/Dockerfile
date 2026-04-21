FROM node:25@sha256:3953ec6a2c10154a58ccf4ba48083ddfe3f8641d63f0d1d5cb8a4a78169123a7 AS frontend-build
WORKDIR /app

RUN npm install -g pnpm

COPY package.json pnpm-lock.yaml ./
RUN pnpm install

COPY . .

EXPOSE 5173

CMD ["pnpm", "run" , "dev"]