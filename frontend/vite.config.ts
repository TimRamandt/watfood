/// <reference types="vitest" />

import { defineConfig } from 'vite';
import analog from '@analogjs/platform';

// https://vitejs.dev/config/
export default defineConfig(({ mode }) => ({
  server: {
    cors: {
      origin: 'http://localhost:5000'
    }
  },
  build: {
    target: ['es2020'],
  },
  resolve: {
    mainFields: ['module'],
  },
  plugins: [
    analog({
      ssr: false,
      static: true,
      prerender: {
        routes: [],
      },
    }),
  ],
}));
