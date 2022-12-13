import game1
import game2
import view
import logger


def run():
    mode = view.choose_mode()
    if mode == '1':
        result = game1.run_game()
        view.show_results(result)
        logger.log_result(result)
    if mode == '2':
        result = game2.run_game()
        view.show_results(result)
        logger.log_result(result)
        

# import Game1
# import Game2
# import View
# import Logger

# def run():
#     mode = View.choose_mood()
#     if mode == '1':
#         result = Game1.run_game()
#         view.show_results(result)
#         Logger.log_result(result)
#     if mode == '2':
#         result = Game2.run_game()
#         View.show_result(result)
#         view.show_results(result)
#         Logger.log_result(result)


# run()
