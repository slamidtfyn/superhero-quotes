FROM nginx:alpine as base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM node:18 AS publish
WORKDIR /src
COPY . .
RUN npm install
RUN npm run build

FROM base AS final
COPY --from=publish /src/dist /usr/share/nginx/html

