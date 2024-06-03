# CrawlNovel
LightNovel Web App crawls Light novels from other websites using Amateur Clean Architecture, ASP.NET, ReactJS

# Projects
One provides APIs, one crawls data periodly, one for UI

# Main work flow
Crawler scans all novel links from html response, requests html from these links, extracts info of books and store in database
crawler crawls and stores infor for each 30 minutes, frontend requests {chapter_URL, content_div_id}, uses this URL to request content page, extracts content from response and renders it.

# Plugin Crawl Source and Export file format feature


# Architecture
![architecture drawio](https://github.com/cvtai105/CrawlNovel/assets/95127990/c034e1c0-afd3-4a62-bd3a-764ae4357041)


# Database schema
![dbschema drawio](https://github.com/cvtai105/CrawlNovel/assets/95127990/da9b8807-c86a-4efd-b563-882c4fc7983d)


