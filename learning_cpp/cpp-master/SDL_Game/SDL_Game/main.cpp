// SDL Game

#include <iostream>
#include <SDL.h>

using namespace std;

int main() {
    
    // declare variables
    const int SCREEN_WIDTH  = 800;
    const int SCREEN_HEIGHT = 600;
    
    // init SDL
    if(SDL_Init(SDL_INIT_VIDEO) < 0) {
        cout << "SDL init failed" << endl;
        return 1;
    }
    
    // create window
    SDL_Window *window = SDL_CreateWindow(
                          "Particle Fire",
                          SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED,
                          SCREEN_WIDTH, SCREEN_HEIGHT,
                          SDL_WINDOW_SHOWN
                         );
    
    // test if window exists
    if (window == NULL) {
        SDL_Quit();
        return 2;
    }
    
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_PRESENTVSYNC);
    SDL_Texture *texture = SDL_CreateTexture(
                                             renderer,
                                             SDL_PIXELFORMAT_RGB888,
                                             SDL_TEXTUREACCESS_STATIC,
                                             SCREEN_WIDTH, SCREEN_HEIGHT
                                             );
    
    if (renderer == NULL) {
        cout << "ERROR no renderer" << endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 3;
    }
    
    if (texture == NULL) {
        cout << "ERROR no texture" << endl;
        SDL_DestroyWindow(window);
        SDL_DestroyRenderer(renderer);
        SDL_Quit();
        return 4;
    }
    
    Uint32 *buffer = new Uint32[SCREEN_WIDTH*SCREEN_HEIGHT];
    
    memset(buffer, 0, SCREEN_WIDTH*SCREEN_HEIGHT*sizeof(Uint32));
    
    for (int i = 0; i<SCREEN_WIDTH*SCREEN_HEIGHT; i++) {
        buffer[i] = 0xFFFFFFFF;
    }
    
    SDL_UpdateTexture(texture, NULL, buffer, SCREEN_WIDTH*sizeof(Uint32));
    SDL_RenderClear(renderer);
    SDL_RenderCopy(renderer, texture, NULL, NULL);
    SDL_RenderPresent(renderer);

    
    // create game loop
    bool quit = false;
    SDL_Event event;
    
    while (!quit) {
        // draw particles
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT) {
                quit = true;
            }
        }
    }
    
    SDL_DestroyRenderer(renderer);
    SDL_DestroyTexture(texture);
    SDL_DestroyWindow(window);
    SDL_Quit();
    
    return 0;
}
