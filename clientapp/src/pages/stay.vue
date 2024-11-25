<template>
    <v-row>
        <v-col md="8" offset-md="2">
            <div class="ibe" data-region="emea" data-channelcode="southwoodhouseandcottagesdirect" data-widget="embed"></div>
        </v-col>
    </v-row>
  </template>
  
  <script lang="ts" setup>
import { onMounted, onUnmounted } from 'vue';

let scriptElement: HTMLScriptElement | null = null;

onMounted(() => {
  // Check if the script is already loaded
  if (!document.querySelector('script[src="https://widget.siteminder.com/ibe.min.js"]')) {
    scriptElement = document.createElement('script');
    scriptElement.src = "https://widget.siteminder.com/ibe.min.js";
    scriptElement.async = true;
    document.body.appendChild(scriptElement);

    scriptElement.onload = () => {
      console.log('Siteminder widget loaded');
    };

    scriptElement.onerror = () => {
      console.error('Failed to load Siteminder widget');
    };
  }
});

onUnmounted(() => {
  if (scriptElement && document.body.contains(scriptElement)) {
    document.body.removeChild(scriptElement);
    console.log('Siteminder widget script removed');
  }
});
</script>
  