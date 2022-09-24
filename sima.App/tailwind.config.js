/** @type {import('tailwindcss').Config} */ 
const plugins = require('tailwindcss/plugin');


module.exports = {
  mode: 'jit',
  darkmode: 'class',
  content:[ "./sima.App.Frontend/Pages/**/*.cshtml"],
  theme: {
    extend: {
      colors: {
        "primary": "#1e3a8a",
        "primary-dark": "#1e293b",
        "secondary": "#27272a",
        "secondary-dark": "#0f172a",
      },
      fontFamily: {
        'poppins': ['Poppins', 'sans-serif'],
        'roboto': ['Roboto', 'sans-serif']
      },
    },
  },
  plugins: [  
    require ('@tailwindcss/forms'), 
    plugins(function({addUtilities, theme}){
      const newUtilities={
        '.custom-scrollbar': {
          '.custom-scrollbar::-webkit-scrollbar': { width: '6px' },
          '.custom-scrollbar::-webkit-scrollbar-track': { background: theme('bg-secondary')},
          '.custom-scrollbar::-webkit-scrollbar-thumb': { background: '#a1a1aa' },
          '.custom-scrollbar::-webkit-scrollbar-thumb:hover': {background: '#71717a'},
        }
      }
      addUtilities(newUtilities, ['responsive', 'hover'])
    })
  ],
}