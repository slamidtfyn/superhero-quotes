<script setup lang="ts">
import {ref} from 'vue';

const quote = ref("Loading quote....");

setInterval(() => {
  fetch("http://localhost:5086/Quote", {mode: 'cors'})
      .then(p => p.json())
      .then(p => quote.value = p.quote);
}, 10000);
</script>

<template>
  <h1>{{ quote }}</h1>
</template>

<style scoped>

</style>